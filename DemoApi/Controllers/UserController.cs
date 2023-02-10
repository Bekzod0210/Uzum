using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Uzum.Api.Models;
using Uzum.Infrastructure.Abstractions;

namespace Uzum.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IAuthService _authService;

        public UserController(IAuthService authService)
        {
            _authService = authService; 
        }

        [HttpPost("Login")]
        public async Task<IActionResult> LoginAsync([FromForm] LoginRequest request)
        {
            var token = await _authService.LoginAsync(request.UserName, request.Password);
            return Ok(token);
        }
    }
}
