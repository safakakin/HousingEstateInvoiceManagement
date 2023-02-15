using Business.Abstract;
using Core.Dto;
using Core.Entities.Concrete;
using Core.Utilities.Result;
using Core.Utilities.Security.JWT;
using MapsterMapper;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost]
        [Route("login")]
        public async Task<ActionResult> Login(UserForLoginDto userForLoginDto)
        {
            IDataResult<User> result = await _authService.LoginAsync(userForLoginDto);
            if (result.Success == false)
            {
                return BadRequest(result);
            }
            IDataResult<AccessToken> token = await _authService.CreateAccessTokenAsync(result.Data);  
            
            return Ok(token);
        }
    }
}
