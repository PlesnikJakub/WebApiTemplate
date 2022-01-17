using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;
using Application.UseCases.User.GetUser;

namespace WebApi.UseCases.v1.GetUser;

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
    public async Task<GetUserResponse> Get(Guid userGuid)
    {
        return new GetUserResponse
        {
            Guid = userGuid,
        };
    }
}
