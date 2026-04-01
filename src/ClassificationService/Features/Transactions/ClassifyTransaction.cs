using Microsoft.AspNetCore.Mvc;

namespace ClassificationService.Features.Transactions
{
    [ApiController]
    [Route("api/features/transactions")]
    public class ClassifyTransaction : ControllerBase
    {
        [HttpPost("classify")]
        public IActionResult Post([FromBody] object transaction)
        {
            return Ok("Transaction classified successfully.");
        }
    }
}
