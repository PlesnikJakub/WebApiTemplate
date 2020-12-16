using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.GetUser
{
    public class GetUserUseCase : IGetUser
    {
        private IOutputPort _outputPort;

        public GetUserUseCase()
        {
            this._outputPort = new GetAccountPresenter();
        }
        public Task Execute(GetUserInput input)
        {
            throw new NotImplementedException();
        }

        public void SetOutputPort(IOutputPort outputPort)
        {
            throw new NotImplementedException();
        }

        private async Task GetUserInternal(Guid accountId)
        {

            this._outputPort.NotFound();
        }
    }
}
