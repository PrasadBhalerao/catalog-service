using CatalogService.Feature;
using CatalogService.Models;
using Microsoft.AspNetCore.Mvc;

namespace CatalogService.Controllers
{
    [ApiController]
    [Route("/api/login")]
    public class LoginController : Controller
    {
        private readonly LoginHandler _loginHandler;

        public LoginController()
        {
            _loginHandler = new LoginHandler();
        }

        [HttpPost]
        public IActionResult Login([FromBody] Login loginRequest)
        {
            if (loginRequest == null || string.IsNullOrEmpty(loginRequest.UserName) || string.IsNullOrEmpty(loginRequest.Password))
            {
                return BadRequest("Username and password are required.");
            }

            if (_loginHandler.HandleLogin(loginRequest))
            {
                return Ok(new { Message = "Login successful" });
            }
            else
            {
                return Unauthorized("Invalid username or password.");
            }
        }
    }
}
