using Azure;
using Microsoft.AspNetCore.Http;
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
        var result = await _rag.Ask(req.Question, req.MemberId);
        return Ok(result);
    }
}

