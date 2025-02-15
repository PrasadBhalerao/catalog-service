using CatalogService.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CatalogService.Controllers
{
    [ApiController]
    [Route("/api/login")]
    public class LoginController : Controller
    {
        [HttpPost]
        public IActionResult Login([FromBody] Login loginRequest)
        {
            if (loginRequest == null || string.IsNullOrEmpty(loginRequest.UserName) || string.IsNullOrEmpty(loginRequest.Password))
            {
                return BadRequest("Username and password are required.");
            }

            if (loginRequest.UserName == "admin" && loginRequest.Password == "admin")
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
