using AutoMapper;
using EY.TalentSurfer.Domain;
using EY.TalentSurfer.Services.Contracts;
using EY.TalentSurfer.Support;
using EY.TalentSurfer.Support.Exceptions;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace EY.TalentSurfer.Services
{
    public class UserService : IUserService
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IMapper _mapper;
        private readonly AuthenticationSettings _authSettings;

        public UserService(UserManager<User> userManager, SignInManager<User> signInManager, IMapper mapper, IOptions<AuthenticationSettings> options)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _mapper = mapper;
            _authSettings = options.Value;
        }

        public AuthenticationProperties LoginWithGoogle()
        {
            return _signInManager.ConfigureExternalAuthenticationProperties("Google", "api/User/HandleLogin");
        }

        public async Task<string> HandleLoginAsync()
        {
            var info = await _signInManager.GetExternalLoginInfoAsync();
            var result = await _signInManager.ExternalLoginSignInAsync(info.LoginProvider, info.ProviderKey, isPersistent: false);

            var user = result.Succeeded ? await _userManager.FindByLoginAsync("Google", info.ProviderKey) : await CreateUser(info);

            return GenerateJwtToken(user);
        }

        private async Task<User> CreateUser(ExternalLoginInfo info)
        {
            var email = info.Principal.FindFirstValue(ClaimTypes.Email);
            var newUser = new User
            {
                UserName = email,
                Email = email,
                EmailConfirmed = true
            };
            var createResult = await _userManager.CreateAsync(newUser);
            if (!createResult.Succeeded)
                throw new CreateUserException(createResult.Errors.Select(e => e.Description));

            await _userManager.AddLoginAsync(newUser, info);
            var newUserClaims = info.Principal.Claims.Append(new Claim(ClaimTypes.NameIdentifier, newUser.Id.ToString()));
            await _userManager.AddClaimsAsync(newUser, newUserClaims);
            return newUser;
        }

        private string GenerateJwtToken(User user)
        {
            var key = Encoding.UTF8.GetBytes(_authSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                        new Claim(ClaimTypes.NameIdentifier, user.Id.ToString())
                }),
                Expires = DateTime.UtcNow.AddMinutes(_authSettings.TokenDuration),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256)
            };
            var tokenHandler = new JwtSecurityTokenHandler();
            var securityToken = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(securityToken);
        }
    }
}
