using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Application.UseCases.GetUser;
using System;

namespace WebApi.UseCases.v1.GetUser
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private IGetUser useCase;
        public UsersController(IGetUser getUser)
        {
            useCase = getUser;
        }

        [HttpGet]
        [Route("{userId:guid}")]
        public async Task<IActionResult> Get(Guid userId)
        {
            var input = new GetUserInput
            {
                UserId = userId
            };

            await useCase.Execute(input);
            return Ok();
        }
    }
}
