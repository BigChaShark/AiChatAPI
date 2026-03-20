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
    private readonly DbQueryService _dbQueryService;

    public AiService(HttpClient http, IConfiguration config, APIAIContext db, Saveone saveone, DbQueryService dbQueryService)
    {
        _http = http;
        _config = config;
        _db = db;
        this.saveoneContext = saveone;
        _dbQueryService = dbQueryService;
    }

    public async Task<IntentResult> AnalyzeIntent(
    string question,
    int enterPriseID,
    string userID)
    {
        string schemaText = "";
        schemaText = SchemaHelper.GetDatabaseSchema(_db, enterPriseID);
        var history = await GetChatHistory(enterPriseID, userID);
        string prompt = "";
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

    public async Task<IntentResult> AnalyzeIntentSaveone(
    string question,
    int enterPriseID,
    string userID)
    {
        string data = "";
        data = _dbQueryService.QuerySaveone(userID);
        var history = await GetChatHistory(enterPriseID, userID);
        string prompt = "";
        #region DF Prompt
        prompt = $$"""
            You are an AI that classifies user intent.

            User data:
            {{data}}

            Previous conversation:
            {{history}}

            Current message:
            {{question}}

            Your job:
            - Understand the user's message
            - Decide the intent of the message

            Intent types:
            - query  → Questions related to information in User data
            - topup  → Questions or requests related to adding money / top-up WITH amount specified
            - topup_clarify → User wants to top-up but does NOT specify the amount
            - chat   → General conversation not related to data or top-up

            Rules:
            - If the question is about information found in User data → intent = "query"
            - If the user asks about top-up, เติมเงิน, add balance, or similar:
                - If an amount is clearly specified → intent = "topup"
                - Extract the amount and store it in "amount" (numbers only, no currency symbols)
                - If NO amount is specified → intent = "topup_clarify"
            - If none of the above conditions match → intent = "chat"
            - Use context from previous conversation (history) to help decide
            - If unsure → default to "chat"

            Return ONLY valid JSON. No explanation.

            For chat:
            {
              "intentType": "chat",
              "table": "",
              "fields": [],
              "filters": []
            }

            For query:
            {
              "intentType": "query",
              "table": "",
              "fields": [],
              "filters": []
            }

            For topup:
            {
              "intentType": "topup",
              "amount": "",
              "table": "",
              "fields": [],
              "filters": []
            }

            For topup_clarify:
            {
              "intentType": "topup_clarify",
              "table": "",
              "fields": [],
              "filters": []
            }
            """;
        #endregion
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

    private async Task<string> GetChatHistory(int enterPriseID, string userID)
    {
        var chats = await _db.ChatLogs
            .Where(x => x.EnterPriseId == enterPriseID && x.UserId == userID)
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

    public async Task<string> GenerateAnswer(string question, object data, int enterPriseID)
    {
        var prompt = $"""
            You are a helpful assistant.

            Your task:
            - Answer the question using the provided data.
            - Use simple Thai language.
            - Make the answer VERY easy to read.

            Format rules (IMPORTANT):
            - Do NOT use markdown symbols like **, ##, | tables
            - Do NOT use code blocks
            - Use plain text only
            - Use short sentences
            - Use line breaks between sections
            - Use simple bullet points like:
              - ข้อความ
            - Avoid technical field names (like ReservationTimeStart)
            - Convert data into human-friendly words

            Style:
            - Friendly and natural
            - Like explaining to a normal user (not developer)

            Example style:

            ข้อมูลของคุณ
            - เบอร์โทร: 094xxxxxxx
            - ยอดเงิน: 0 บาท

            ตลาดที่เกี่ยวข้อง
            1. ศรีสมาน
               - ระดับ: 3 ดาว
               - เวลาเปิดจอง: 10:00 - 15:00

            2. ประตูกรุงเทพ
               - ระดับ: 2 ดาว
               - เวลาเปิดจอง: 10:30 - 15:00

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
