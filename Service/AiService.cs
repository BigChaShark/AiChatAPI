using System.Net.Http.Headers;
using System.Text;
using AiChatAPI.Data;
using AiChatAPI.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

public class AiService
{
    private readonly HttpClient _http;
    private readonly IConfiguration _config;
    private readonly APIAIContext _db;
    private readonly Saveone saveoneContext;

    public AiService(HttpClient http, IConfiguration config, APIAIContext db, Saveone saveone)
    {
        _http = http;
        _config = config;
        _db = db;
        this.saveoneContext = saveone;
    }

    public async Task<IntentResult> AnalyzeIntent(
    string question,
    int enterPriseID,
    long? userID)
    {

        string schemaText = "";
        if (enterPriseID == 5)
        {
            schemaText = SchemaHelper.GetDatabaseSchemaSaveone(saveoneContext, enterPriseID);
        }
        else
        {
            schemaText = SchemaHelper.GetDatabaseSchema(_db, enterPriseID);
        }

        var history = await GetChatHistory(enterPriseID, userID);
        string prompt = "";

        if (enterPriseID == 5)
        {
            #region Saveone Prompt
            prompt = $$"""
            You are an AI that decides how to Answer the Question form customer.

            Data:
            {{schemaText}}

            Previous conversation:
            {{history}}

            Current Question:
            {{question}}

            Your job:
            - Decide a question with previous conversation and database schema.
            - Decide which table is needed
            - Decide which fields are relevant
            - Detect if the question is comparison (cheaper, more expensive, higher, lower)
            - Detect if information is insufficient
            - Decide intentType as one of:
                - chat
                - query
                - compare
                - clarify

            IMPORTANT RULES:
            - Always use Filters for selecting specific records.
            - For compare, DO NOT use compareValues.
            - For compare, use multiple filters (same field) to represent items.
            - If required information is missing → intentType = "clarify"
            - Always return valid JSON only. No explanation.

            For query:
            {
              "intentType": "query",
              "table": "TableName",
              "fields": ["Field1","Field2"],
              "filters": [
                {
                  "field": "ColumnName",
                  "operator": "LIKE",
                  "value": "Value"
                }
              ]
            }

            For compare:
            {
              "intentType": "compare",
              "table": "TableName",
              "fields": ["Name","Price"],
              "compareField": "Price",
              "filters": [
                {
                  "field": "Name",
                  "operator": "=",
                  "value": "Item1"
                },
                {
                  "field": "Name",
                  "operator": "=",
                  "value": "Item2"
                }
              ]
            }

            For clarify:
            {
              "intentType": "clarify",
              "clarifyQuestion": "Please specify more details."
            }

            For chat:
            {
              "intentType": "chat",
              "table": "",
              "fields": [],
              "filters": []
            }
            """;
            #endregion
        }
        else
        {
            #region DF Prompt
            prompt = $$"""
            You are an AI that decides how to query a database.

            Available tables and fields:
            {{schemaText}}

            Previous conversation:
            {{history}}

            Current Question:
            {{question}}

            Your job:
            - Decide a question with previous conversation and database schema.
            - Decide which table is needed
            - Decide which fields are relevant
            - Detect if the question is comparison (cheaper, more expensive, higher, lower)
            - Detect if information is insufficient
            - Decide intentType as one of:
                - chat
                - query
                - compare
                - clarify

            IMPORTANT RULES:
            - Always use Filters for selecting specific records.
            - For compare, DO NOT use compareValues.
            - For compare, use multiple filters (same field) to represent items.
            - If required information is missing → intentType = "clarify"
            - Always return valid JSON only. No explanation.

            For query:
            {
              "intentType": "query",
              "table": "TableName",
              "fields": ["Field1","Field2"],
              "filters": [
                {
                  "field": "ColumnName",
                  "operator": "LIKE",
                  "value": "Value"
                }
              ]
            }

            For compare:
            {
              "intentType": "compare",
              "table": "TableName",
              "fields": ["Name","Price"],
              "compareField": "Price",
              "filters": [
                {
                  "field": "Name",
                  "operator": "=",
                  "value": "Item1"
                },
                {
                  "field": "Name",
                  "operator": "=",
                  "value": "Item2"
                }
              ]
            }

            For clarify:
            {
              "intentType": "clarify",
              "clarifyQuestion": "Please specify more details."
            }

            For chat:
            {
              "intentType": "chat",
              "table": "",
              "fields": [],
              "filters": []
            }
            """;
            #endregion
        }

        var response = await Send(prompt);

        if (string.IsNullOrWhiteSpace(response))
            throw new InvalidOperationException("AI response was null.");

        IntentResult? result;

        try
        {
            result = JsonConvert.DeserializeObject<IntentResult>(response);
        }
        catch (Exception ex)
        {
            throw new JsonSerializationException(
                $"Failed to deserialize AI response: {response}", ex);
        }

        if (result == null)
            throw new JsonSerializationException("Failed to deserialize.");

        // Safe defaults
        result.Filters ??= new List<FilterCondition>();
        result.Fields ??= new List<string>();
        result.Table ??= "";
        result.IntentType ??= "chat";

        // 🔥 Safety: ถ้า compare แต่ไม่มี CompareField → force clarify
        if (result.IntentType == "compare" &&
            string.IsNullOrEmpty(result.CompareField))
        {
            result.IntentType = "clarify";
            result.ClarifyQuestion = "ไม่พบ field สำหรับเปรียบเทียบ กรุณาระบุให้ชัดเจนครับ";
        }

        return result;
    }

    private async Task<string> GetChatHistory(int enterPriseID, long? userID)
    {
        var chats = await _db.ChatLogs
            .Where(x => x.EnterPriseId == enterPriseID && x.UserId == userID.ToString())
            .OrderByDescending(x => x.TimeStamp)
            .Take(5)
            .OrderBy(x => x.TimeStamp)
            .ToListAsync();

        if (!chats.Any())
            return "No previous conversation.";

        return string.Join("\n",
            chats.Select(x => $"User: {x.Q}\nAI: {x.A}")
        );
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
        Do aswer only the question without extra explanation.
        Answer only greetings question , if not a greetings question answer Like "sorry is out of hand".

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
