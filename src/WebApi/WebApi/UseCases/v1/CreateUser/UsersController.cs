using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace WebApi.UseCases.v1.CreateUser
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpPost]
        public async Task<CreateUserResponse> Post(CreateUserRequest request)
        {
            return new CreateUserResponse
            {
                Name = request.Name,
                Email = request.Email,
                Age = request.Age
            };
        }
    }
}
