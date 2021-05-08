using System;
using System.Threading.Tasks;

namespace Application.UseCases.GetUser
{
    public interface IGetUserUseCase
    {
        Task Execute(GetUserInput input);

        void SetOutputPort(IOutputPort outputPort);
    }
}
