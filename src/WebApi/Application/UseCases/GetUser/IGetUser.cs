using System;
using System.Threading.Tasks;

namespace Application.UseCases.GetUser
{
    public interface IGetUser
    {
        Task Execute(GetUserInput input);

        void SetOutputPort(IOutputPort outputPort);
    }
}
