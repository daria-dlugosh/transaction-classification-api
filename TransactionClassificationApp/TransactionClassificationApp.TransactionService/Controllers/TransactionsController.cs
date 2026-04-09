using Microsoft.AspNetCore.Mvc;

namespace TransactionClassificationApp.TransactionService.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TransactionsController : ControllerBase
{
    [HttpPost]
    public async Task<ActionResult<object>> Create([FromBody] object request)
    {
        // TODO: Implement
        return Ok();
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<object>>> GetAll()
    {
        // TODO: Implement
        return Ok();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<object>> GetById(Guid id)
    {
        // TODO: Implement
        return NotFound();
    }
}
