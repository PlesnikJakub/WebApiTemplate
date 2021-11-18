using System;

namespace Application.UseCases.User.GetUser
{
    public record GetUserInput
    {
        public Guid UserId { get; init; }
    }
}