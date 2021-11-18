using System;
using System.Threading.Tasks;

namespace Application.UseCases.User.GetUser
{
    public class GetUserUseCase : IGetUserUseCase
    {
        private IOutputPort _outputPort;

        public GetUserUseCase()
        {
            _outputPort = new GetUserPresenter();
        }
        public Task Execute(GetUserInput input)
        {
            // TODO
            return Task.FromResult(0);
        }

        public void SetOutputPort(IOutputPort outputPort)
        {
            throw new NotImplementedException();
        }

        private async Task GetUserInternal(Guid accountId)
        {
            _outputPort.NotFound();
        }
    }
}
