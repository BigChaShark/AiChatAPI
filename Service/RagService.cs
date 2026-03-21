
using AiChatAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

public class RagService
{
    private readonly AiService _ai;
    private readonly DbQueryService _db;
    private readonly APIAIContext _dbContext;
    private readonly Saveone saveoneContext;

    public RagService(AiService ai, DbQueryService db, APIAIContext dbContext , Saveone saveone )
    {
        _ai = ai;
        _db = db;
        _dbContext = dbContext;
        saveoneContext = saveone;
    }

    public async Task<string> Ask(
    string question,
    string userID,
    string enterPriseID)
    {
        if (userID == null)
            throw new Exception("User not authenticated.");

        // ===== 1. วิเคราะห์ Intent =====
        var intent = await _ai.AnalyzeIntent(
            question,
            enterPriseID,
            userID);

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
        //_dbContext.ChatLogs.Add(new ChatLog
        //{
        //    EnterPriseId = enterPriseID,
        //    UserId = userID.ToString(),
        //    Q = question,
        //    A = finalAnswer,
        //    TimeStamp = DateTime.Now
        //});

        //await _dbContext.SaveChangesAsync();

        return finalAnswer;
    }

    public async Task<string> SaveoneAsk(
    string question,
    string userID,
    string enterPriseID)
    {  
        if (userID == null)
            throw new Exception("User not authenticated.");

        // ===== 1. วิเคราะห์ Intent =====
        var intent = await _ai.AnalyzeIntentSaveone(
            question,
            enterPriseID,
            userID);

        string finalAnswer;

        switch (intent.IntentType?.ToLower())
        {

            case "query":
                var data = _db.QuerySaveone(userID);
                finalAnswer = await _ai.GenerateAnswer(question, data, enterPriseID);
                break;

            case "chat":
                var chatData = await _ai.Chat(question);
                finalAnswer = await _ai.GenerateAnswer(question, chatData, enterPriseID);
                break;

            case "topup":
                finalAnswer = $"QR Code -----.....-/// {intent.Amount} ///-......------";
                break;
            case "topup_clarify":
                var clarify = "กรุณา ระบุยอดเงิน หรือ ระบุให้ชัดเจนกว่านี้ครับ";
                finalAnswer = await _ai.GenerateAnswer(question, clarify, enterPriseID);
                break;

            default:
                throw new Exception("Unsupported intent type");
        }

        // ===== 2. Save Chat Log =====
        //_dbContext.ChatLogs.Add(new ChatLog
        //{
        //    EnterPriseId = enterPriseID,
        //    UserId = userID.ToString(),
        //    Q = question,
        //    A = finalAnswer,
        //    TimeStamp = DateTime.Now
        //});

        //await _dbContext.SaveChangesAsync();

        return finalAnswer;
    }

    public SaveoneCheckPMData CheckTopup(string ref1, string ref2, decimal amount, string enterpriseID, string userID)
    {
        var checkResult = saveoneContext.ScbPaymentConfirmations
            .Where(c => c.BillPaymentRef1 == ref1 && c.Amount == amount)
            .FirstOrDefault();
        if (checkResult == null) return new SaveoneCheckPMData { Mes = "ไม่พบข้อมูลการชำระเงิน", Amount = 0, Balance = 0, isTopupSuccess = false };
        if (checkResult.Status == 1)
        {
            var member = saveoneContext.SaveoneGoMembers.FirstOrDefault(x => x.LineUserId == userID);
            if (member == null) return new SaveoneCheckPMData { Mes = "ไม่พบข้อมูลสมาชิก", Amount = 0, Balance = 0, isTopupSuccess = false };
            var balance = saveoneContext.Sgsavings.Where(x => x.MemberId == member.MemberId).Select(s => s.BalanceAmount).FirstOrDefault();
            return new SaveoneCheckPMData { Mes = "เติมเงินสำเร็จ", Amount = amount, Balance = balance.Value, isTopupSuccess = true };
        }
        else
        {
            return new SaveoneCheckPMData { Mes = "การชำระเงินยังไม่ถูกยืนยัน", Amount = amount, Balance = 0, isTopupSuccess = false };
        }
    }
}

