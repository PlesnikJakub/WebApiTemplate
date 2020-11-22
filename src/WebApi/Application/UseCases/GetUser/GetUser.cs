using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.GetUser
{
    public class GetUser : IGetUser
    {
        private IOutputPort _outputPort;

        public GetUser()
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

        private async Task GetUserInternal(AccountId accountId)
        {

            this._outputPort.NotFound();
        }
    }
}
