using Azure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/ai")]
public class AiController : ControllerBase
{
    private readonly RagService _rag;

    public AiController(RagService rag)
    {
        _rag = rag;
    }

    [HttpPost("ask")]
    public async Task<IActionResult> Ask(AiRequest req)
    {
        try
        {
            var result = await _rag.Ask(req.Question, req.UserID , req.enterPriseId);
            return Ok(new AiResponse
            {
                Answer = result,
                Success = true
            });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new AiResponse
            {
                Answer = ex.Message,
                Success = false
            });
        }

    }

    [HttpPost("saveone/ask")]
    public async Task<IActionResult> SaveOneAsk(AiRequest req)
    {
        try
        {
            var result = await _rag.SaveoneAsk(req.Question, req.UserID, req.enterPriseId);
            return Ok(new AiResponse
            {
                Answer = result,
                Success = true
            });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new AiResponse
            {
                Answer = ex.Message,
                Success = false
            });
        }

    }

    [HttpPost("saveone/checkpayment")]
    public async Task<IActionResult> SaveOneCheckPayment(SaveoneCheckPRQ req)
    {
        try
        {
            var result = _rag.CheckTopup(req.Ref1 , req.Ref2 , req.Amount , req.enterPriseId , req.UserID);
            return Ok(new SaveoneCheckPMRes
            {
                Message = result.Mes,
                Amount = result.Amount,
                Balance = result.Balance,
                Success = true,
                isTopupSuccess = result.isTopupSuccess
            });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new SaveoneCheckPMRes
            {
                Message = ex.Message,
                Success = false
            });
        }

    }
}

