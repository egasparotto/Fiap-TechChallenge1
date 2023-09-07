using FiapBlog.Domain.Interfaces.Services.Token;
using FiapBlog.Domain.Interfaces.Services.Users;
using FiapBlog.WebAPI.Model.Auth;

using Microsoft.AspNetCore.Mvc;

namespace FiapBlog.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]/[Action]")]
    public class AuthController : ControllerBase
    {
        protected IUserService UserService { get; set; }
        protected ITokenService TokenService { get; set; }
        public AuthController(IUserService userService, ITokenService tokenService)
        {
            UserService = userService;
            TokenService = tokenService;
        }

        [HttpPost]
        public IActionResult Login(LoginDTO dto)
        {
            var user = UserService.GetByUsername(dto.Username);
            if (user != null) 
            {
                if(user.ValidatePassword(dto.Password))
                {
                    return Ok(TokenService.GenerateToken(user));
                }
            }
            return Unauthorized();
        }
    }
}
