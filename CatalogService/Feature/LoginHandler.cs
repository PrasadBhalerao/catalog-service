using CatalogService.Models;
using CatalogService.Repository;

namespace CatalogService.Feature
{
    public class LoginHandler
    {
        private readonly LoginRepository _loginRepository;

        public LoginHandler()
        {
            _loginRepository = new LoginRepository();
        }

        public bool HandleLogin(Login loginRequest)
        {
            return _loginRepository.ValidateLogin(loginRequest);
        }
    }
}
