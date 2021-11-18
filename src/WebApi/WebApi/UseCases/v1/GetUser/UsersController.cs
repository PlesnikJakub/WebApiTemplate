using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Application.UseCases.GetUser;
using System;
using Application.UseCases.User.GetUser;

namespace WebApi.UseCases.v1.GetUser
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private IGetUserUseCase useCase;
        public UsersController(IGetUserUseCase getUser)
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
