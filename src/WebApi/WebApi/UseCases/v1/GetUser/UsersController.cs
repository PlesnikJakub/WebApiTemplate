using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace WebApi.UseCases.v1.GetUser
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpGet("{test}")]
        public async Task<IActionResult> Get(string base64Payload = null)
        {
            return Ok();
        }
    }
}
