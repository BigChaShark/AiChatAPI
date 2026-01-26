using System.Net.Http.Headers;
using System.Text;
using AiChatAPI.Data;
using Newtonsoft.Json;

public class AiService
{
    private readonly HttpClient _http;
    private readonly IConfiguration _config;
    private readonly AppDbContext _db; // Add this field to fix the error

    public AiService(HttpClient http, IConfiguration config, AppDbContext db)
    {
        _http = http;
        _config = config;
        _db = db; 
    }

    public async Task<IntentResult> AnalyzeIntent(string question)
    {
        var schemaText = SchemaHelper.GetDatabaseSchema(_db);

        var prompt = $$"""
        You are an AI that decides how to query a database.

        Available tables and fields:
        {{schemaText}}

        Your job:
        - Decide which table(s) are needed
        - Decide which fields are relevant
        - Decide whether MemberId is required
        - Decide whether the user is Asking for database information or Just chatting or asking general questions

        Rules:
        - if in table you select have field named "MemberId" memberIdField = "MemberId" if not found memberIdField = "Id"
        - If the question can be answered without database data → intentType = "chat"
        - If the question requires data → intentType = "query"
        - For chat, do NOT choose any table

        Return JSON only in this exact format:
        {
          "table": "TableName",
          "fields": ["Field1", "Field2"],
          "useMemberId": true,
          "memberIdField": "MemberId"
          "intentType": "query" // or "chat"
        }

        Question:
        {{question}}
        """;

        var response = await Send(prompt);
        if (response == null)
        {
            throw new InvalidOperationException("The response from the AI service was null.");
        }

        var result = JsonConvert.DeserializeObject<IntentResult>(response);
        if (result == null)
        {
            throw new JsonSerializationException("Failed to deserialize the response into an IntentResult.");
        }

        return result;
    }

    public async Task<string> GenerateAnswer(string question, object data)
    {
        var prompt = $"""
        Answer the question using the data below.

        Question:
        {question}

        Data:
        {JsonConvert.SerializeObject(data)}
        """;

        return await Send(prompt);
    }

    public async Task<string> Chat(string question)
    {
                var prompt = $$"""
        You are a human-like assistant.

        Have a natural conversation.
        Be polite and helpful.
        Do not mention databases or systems.

        User:
        {{question}}
        """;

        return await Send(prompt);
    }

    private async Task<string> Send(string prompt)
    {
        var body = new
        {
            model = _config["OpenRouter:ChatModel"],
            messages = new[]
            {
                new
                {
                    role = "system",
                    content = "You are a helpful AI assistant. Speak naturally and respond like a real person, not a robot."
                },
                new
                {
                    role = "user",
                    content = prompt // <-- English content here
                }
            },
            temperature = 0.8
        };

        var req = new HttpRequestMessage(
            HttpMethod.Post,
            "https://openrouter.ai/api/v1/chat/completions"
        );

        req.Headers.Authorization =
            new AuthenticationHeaderValue("Bearer", _config["OpenRouter:ApiKey"]);

        // 🔥 REQUIRED by OpenRouter
        req.Headers.Add("HTTP-Referer", "http://localhost");
        req.Headers.Add("X-Title", "AiRagApi");

        req.Content = new StringContent(
            JsonConvert.SerializeObject(body),
            Encoding.UTF8,
            "application/json"
        );

        var res = await _http.SendAsync(req);

        // 🔍 debug ตอน error
        if (!res.IsSuccessStatusCode)
        {
            var err = await res.Content.ReadAsStringAsync();
            throw new Exception($"OpenRouter error: {res.StatusCode} - {err}");
        }

        dynamic json = JsonConvert.DeserializeObject(await res.Content.ReadAsStringAsync());
        return json.choices[0].message.content;
    }
}
