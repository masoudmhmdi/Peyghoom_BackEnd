using Microsoft.AspNetCore.Mvc;

namespace Peyghoom_BackEnd.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly string _privetKey = "asdfasdfasdfasdfasd";
        private readonly ILogger<AuthController> _logger;

        public AuthController(ILogger<AuthController> logger)
        {
            _logger = logger;
        }

        [HttpGet("Login")]
        public string Login()
        {
            return "hi";
        }
    }
}
