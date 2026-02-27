using System.Net.Http.Headers;
using System.Text;
using AiChatAPI.Data;
using AiChatAPI.Models;
using Newtonsoft.Json;

public class AiService
{
    private readonly HttpClient _http;
    private readonly IConfiguration _config;
    private readonly APIAIContext _db; // Add this field to fix the error

    public AiService(HttpClient http, IConfiguration config, APIAIContext db)
    {
        _http = http;
        _config = config;
        _db = db; 
    }

    public async Task<IntentResult> AnalyzeIntent(string question, int enterPriseID)
    {
        var schemaText = SchemaHelper.GetDatabaseSchema(_db, enterPriseID);

        var prompt = $$"""
        You are an AI that decides how to query a database.

        Available tables and fields:
        {{schemaText}}

        Your job:
        - Decide which table is needed
        - Decide which fields are relevant
        - Detect if the question is comparison (cheaper, more expensive, higher, lower)
        - Decide whether this is:
            - chat
            - query
            - compare

        Rules:
        - If general talk → intentType = "chat"
        - If asking for data → intentType = "query"
        - If asking comparison between 2 or more items → intentType = "compare"

        For compare:
        - Provide table
        - Provide compareField (like Price)
        - Provide compareValues (list of item names)

        Return JSON only:

        For query:
        {
          "table": "TableName",
          "fields": ["Field1","Field2"],
          "filters": [
            {
              "field": "ColumnName",
              "operator": "LIKE",
              "value": "Value"
            }
          ],
          "intentType": "query"
        }

        For compare:
        {
          "table": "TableName",
          "fields": ["FoodName","Price"],
          "compareField": "Price",
          "compareValues": ["ไก่ย่าง","ส้มตำ"],
          "intentType": "compare"
        }

        For chat:
        {
          "table": "",
          "fields": [],
          "filters": [],
          "intentType": "chat"
        }

        Question:
        {{question}}
        """;

        var response = await Send(prompt);

        if (string.IsNullOrWhiteSpace(response))
            throw new InvalidOperationException("AI response was null.");

        var result = JsonConvert.DeserializeObject<IntentResult>(response);

        if (result == null)
            throw new JsonSerializationException("Failed to deserialize.");

        result.Filters ??= new List<FilterCondition>();
        result.Fields ??= new List<string>();
        result.Table ??= "";
        result.IntentType ??= "chat";

        return result;
    }

    public async Task<string> GenerateAnswer(string question, object data , int enterPriseID)
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
