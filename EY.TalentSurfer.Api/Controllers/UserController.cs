using EY.TalentSurfer.Domain;
using EY.TalentSurfer.Dto.User;
using EY.TalentSurfer.Services.Contracts;
using EY.TalentSurfer.Support;
using EY.TalentSurfer.Support.Api.Attributes;
using EY.TalentSurfer.Support.Exceptions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Threading.Tasks;
using EY.TalentSurfer.Api.Base;

namespace EY.TalentSurfer.Api.Controllers
{
    public class UserController : TalentSurferBaseController
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
                UserSignedInDto token = await _userService.HandleLoginAsync();
                return Redirect(string.Concat(_authenticationSettings.ReturnUrl, $"?token={token.AccessToken}&refreshToken={token.RefreshToken}"));
            }
            catch (UserException ex)
            {
                return Unauthorized(ex.Message);
            }
        }

        [AllowAnonymous]
        [HttpPost("tokens/{refreshToken}/refreshfor/{accessToken}")]
        public async Task<IActionResult> RefreshAccessToken(string refreshToken, string accessToken)
        {
            try
            {
                UserSignedInDto token = await _userService.HandleLoginAsync(refreshToken, accessToken);
                return Redirect(string.Concat(_authenticationSettings.ReturnUrl, $"?token={token.AccessToken}&refreshToken={token.RefreshToken}"));
            }
            catch (RefreshTokenNotFoundException exception)
            {
                return Unauthorized(new { exception.Message });
            }
            catch (RefreshTokenDeniedException exception)
            {
                return Unauthorized(new { exception.Message });
            }
        }

        [HttpPatch("tokens/{refreshToken}/revoke")]
        public async Task<IActionResult> RevokeRefreshToken(string refreshToken)
        {
            try
            {
                await _userService.RevokeRefreshToken(refreshToken);
            }
            catch (RefreshTokenNotFoundException exception)
            {
                return Unauthorized(new { exception.Message });
            }
            catch (RefreshTokenDeniedException exception)
            {
                return Unauthorized(new { exception.Message });
            }
            return NoContent();
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