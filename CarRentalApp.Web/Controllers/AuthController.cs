using CarRentalApp.Application.InterfacesService;
using CarRentalApp.Application.Models.Users;
using Microsoft.AspNetCore.Mvc;

namespace CarRentalApp.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IAuthService _authService;

        public AuthController(IUserService userService, IAuthService authService)
        {
            _userService = userService;
            _authService = authService;
        }

        [HttpPost("signup")]
        public async Task<IActionResult> Register([FromBody] UserCreateDto userCreateDto)
        {
            var existingUser = await _userService.GetUserByEmailAsync(userCreateDto.Email);
            if (existingUser != null)
            {
                return BadRequest("The email is already in use.");

            }

            var hashedPassword = BCrypt.Net.BCrypt.HashPassword(userCreateDto.PasswordHash);
            userCreateDto.PasswordHash = hashedPassword; 

            await _userService.AddUserAsync(userCreateDto);
            return CreatedAtAction(nameof(Login), new { email = userCreateDto.Email }, null);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] UserLoginDto userLoginDto)
        {
            var token = await _authService.AuthenticateAsync(userLoginDto.Email, userLoginDto.Password);
            if (string.IsNullOrEmpty(token))
            {
                return Unauthorized("The email or password is incorrect.");
            }

            return Ok(new { Token = token });
        }
    }
}
