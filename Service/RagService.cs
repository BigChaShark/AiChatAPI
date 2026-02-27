
public class RagService
{
    private readonly AiService _ai;
    private readonly DbQueryService _db;

    public RagService(AiService ai, DbQueryService db)
    {
        _ai = ai;
        _db = db;
    }

    public async Task<string> Ask(string question, long? memberId , int enterPriseID)
    {
        var intent = await _ai.AnalyzeIntent(question, enterPriseID);
        switch (intent.IntentType)
        {
            case "query":
                var data = await _db.Query(intent , enterPriseID);
                return await _ai.GenerateAnswer(question, data , enterPriseID);
            case "chat":
                var dataChat = await _ai.Chat(question );
                return await _ai.GenerateAnswer(question, dataChat, enterPriseID);
        }
        throw new Exception("Unsupported intent type");

    }
}

