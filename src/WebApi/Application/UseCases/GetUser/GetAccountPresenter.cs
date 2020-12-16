using Domain.Models;

namespace Application.UseCases.GetUser
{
    public class GetAccountPresenter : IOutputPort
    {
        public void Invalid()
        {
            throw new System.NotImplementedException();
        }

        public void NotFound()
        {
            throw new System.NotImplementedException();
        }

        public void Ok(UserModel account)
        {
            throw new System.NotImplementedException();
        }
    }
}
