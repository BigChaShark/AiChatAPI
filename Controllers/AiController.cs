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
            var result = await _rag.Ask(req.Question, req.MemberId , req.enterPriseId);
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
            var result = await _rag.Ask(req.Question, req.MemberId, req.enterPriseId);
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
}

