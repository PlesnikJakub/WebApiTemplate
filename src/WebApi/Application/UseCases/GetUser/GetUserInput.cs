using System;

namespace Application.UseCases.GetUser
{
    public record GetUserInput
    {
        public Guid UserId { get; init; }
    }
}