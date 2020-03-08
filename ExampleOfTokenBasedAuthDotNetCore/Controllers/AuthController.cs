using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExampleOfTokenBasedAuthDotNetCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExampleOfTokenBasedAuthDotNetCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : Controller
    {
        protected readonly IAuthenticateService _authService;
        public AuthController(IAuthenticateService authService)
        {
            _authService = authService;
        }
        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromBody]TokenRequest request)
        {
            try
            {
                string token;
                if (_authService.IsAuthenticated(request, out token))
                {
                    return Ok(new { state = true, token });
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return Ok(new { stage = false, messages = ex.Message });
            }
        }
    }
}