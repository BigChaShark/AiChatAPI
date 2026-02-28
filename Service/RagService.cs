
using AiChatAPI.Models;
using Microsoft.EntityFrameworkCore;

public class RagService
{
    private readonly AiService _ai;
    private readonly DbQueryService _db;
    private readonly APIAIContext _dbContext;

    public RagService(AiService ai, DbQueryService db, APIAIContext dbContext  )
    {
        _ai = ai;
        _db = db;
        _dbContext = dbContext;
    }

    public async Task<string> Ask(
    string question,
    long? memberId,
    int enterPriseID)
    {
        if (memberId == null)
            throw new Exception("User not authenticated.");

        // ===== 1. วิเคราะห์ Intent =====
        var intent = await _ai.AnalyzeIntent(
            question,
            enterPriseID,
            memberId.Value);

        string finalAnswer;

        switch (intent.IntentType?.ToLower())
        {
            case "clarify":
                finalAnswer = await _ai.GenerateAnswer(question, intent.ClarifyQuestion ?? "กรุณาระบุข้อมูลเพิ่มเติมครับ", enterPriseID);
                break;

            case "query":
                var data = await _db.Query(intent, enterPriseID);
                finalAnswer = await _ai.GenerateAnswer(question,data,enterPriseID);
                break;

            case "compare":
                var compareData = await _db.Compare(intent, enterPriseID);
                finalAnswer = await _ai.GenerateAnswer( question,compareData,enterPriseID);
                break;

            case "chat":
                var chatData = await _ai.Chat(question);
                finalAnswer = await _ai.GenerateAnswer(question,chatData,enterPriseID);
                break;

            default:
                throw new Exception("Unsupported intent type");
        }

        // ===== 2. Save Chat Log =====
        _dbContext.ChatLogs.Add(new ChatLog
        {
            EnterPriseId = enterPriseID,
            UserId = memberId.Value.ToString(),
            Q = question,
            A = finalAnswer,
            TimeStamp = DateTime.Now
        });

        await _dbContext.SaveChangesAsync();

        return finalAnswer;
    }
}

