using System;

namespace WebApi.UseCases.v1.GetUser
{
    public record GetUserResponse
    {
        public Guid Guid { get; init; }
    }
}
