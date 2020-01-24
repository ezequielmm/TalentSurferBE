using EY.TalentSurfer.Api.Base;
using EY.TalentSurfer.Dto;
using EY.TalentSurfer.Dto.User;
using EY.TalentSurfer.Services.Contracts;
using EY.TalentSurfer.Support;
using EY.TalentSurfer.Support.Exceptions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System.Threading.Tasks;

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
        [HttpGet("tokens/{refreshToken}/refreshfor/{accessToken}")]
        public async Task<IActionResult> RefreshAccessToken(string refreshToken, string accessToken)
        {
            try
            {
                UserSignedInDto token = await _userService.HandleLoginAsync(refreshToken, accessToken);
                return Ok(token);
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

        // GET: api/User
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<IEnumerable<UserReadDto>>> GetUsers()
        {
            var users = await _userService.GetAllAsync();
            return Ok(users);
        }

        // GET: api/Admins
        [HttpGet("Admins")]
        [AllowAnonymous]
        [Authorize]
        public async Task<ActionResult<IEnumerable<UserReadDto>>> GetAdmins()
        {
            var users = await _userService.GetByRoleAsync("Admin");
            return Ok(users);
        }

        // GET: api/User/5
        [HttpGet("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<UserReadDto>> GetUser(int id)
        {
            var user = await _userService.GetAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }

        // POST: api/User
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> PostUser(UserCreateDto user)
        {
            var created = await _userService.CreateUserAsync(user);

            return Ok(created);
            //return //CreatedAtAction("GetUsers", new { id = created.Id }, created);
        }

        // PUT: api/User/5
        [HttpPut("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> PutUser(int id, UserUpdateDTO user)
        {
            if (!await UserExists(id)) return NotFound();

            var updated = await _userService.UpdateAsync(id, user);

            return Ok(updated);
        }

        private async Task<bool> UserExists(int id)
        {
            return await _userService.UserExists(id);
        }
    }
}