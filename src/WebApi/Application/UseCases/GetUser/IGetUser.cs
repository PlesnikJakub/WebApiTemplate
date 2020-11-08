using System;
using System.Threading.Tasks;

namespace Application.UseCases.GetUser
{
    public interface IGetUser
    {
        Task Execute(Guid accountId);

        void SetOutputPort(IOutputPort outputPort);
    }
}
