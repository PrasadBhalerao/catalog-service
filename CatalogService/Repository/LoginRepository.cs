using CatalogService.Models;

namespace CatalogService.Repository
{
    public class LoginRepository
    {
        public bool ValidateLogin(Login loginRequest)
        {
            return loginRequest.UserName == "admin" && loginRequest.Password == "admin";
        }
    }
}
