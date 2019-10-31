using EY.TalentSurfer.Services.Contracts;
using EY.TalentSurfer.Support;
using EY.TalentSurfer.Support.Exceptions;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Threading.Tasks;

namespace EY.TalentSurfer.Api.Controllers
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly AuthenticationSettings _authenticationSettings;

        public UserController(IUserService userService, IOptions<AuthenticationSettings> options)
        {
            _userService = userService;
            _authenticationSettings = options.Value;
        }

        [AllowAnonymous]
        [HttpGet("LoginGoogle")]
        public ActionResult LoginGoogle()
        {
            var authenticationProperties = _userService.LoginWithGoogle();
            return Challenge(authenticationProperties, "Google");
        }

        [AllowAnonymous]
        [HttpGet("HandleLogin", Name = "HandleLogin")]
        public async Task<ActionResult> HandleLogin()
        {
            try
            {
                var token = await _userService.HandleLoginAsync();
                return Redirect(string.Concat(_authenticationSettings.ReturnUrl, $"?token={token}"));
            }
            catch (CreateUserException ex)
            {
                return Unauthorized(ex.Message);
            }
        }
    }
}