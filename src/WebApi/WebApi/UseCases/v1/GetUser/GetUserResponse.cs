using System;

namespace WebApi.UseCases.v1.GetUser
{
    public record GetUserResponse
    {
        public Guid guid { get; init; }
    }
}
