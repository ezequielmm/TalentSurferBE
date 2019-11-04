using EY.TalentSurfer.Domain;
using EY.TalentSurfer.Services.Contracts;
using EY.TalentSurfer.Support;
using EY.TalentSurfer.Support.Api.Attributes;
using EY.TalentSurfer.Support.Exceptions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Threading.Tasks;

namespace EY.TalentSurfer.Api.Controllers
{
    [Authorize]
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
        [HttpGet("HandleLogin")]
        public async Task<ActionResult> HandleLogin()
        {
            try
            {
                var token = await _userService.HandleLoginAsync();
                return Redirect(string.Concat(_authenticationSettings.ReturnUrl, $"?token={token}"));
            }
            catch (UserException ex)
            {
                return Unauthorized(ex.Message);
            }
        }

        [AuthorizedUser(UserStatus.Approved)]
        [HttpPost("{userId}/Approve")]
        public async Task<ActionResult> ApproveUser(int userId)
        {
            if (!await _userService.UserExists(userId)) return NotFound();
            await _userService.ApproveUserAsync(userId);
            return NoContent();
        }

        [AuthorizedUser(UserStatus.Approved)]
        [HttpPost("{userId}/Reject")]
        public async Task<ActionResult> RejectUser(int userId)
        {
            if (!await _userService.UserExists(userId)) return NotFound();
            await _userService.RejectUserAsync(userId);
            return NoContent();
        }
    }
}