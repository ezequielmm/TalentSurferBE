using AutoMapper;
using EY.TalentSurfer.Domain;
using EY.TalentSurfer.Dto;
using EY.TalentSurfer.Dto.RefreshToken;
using EY.TalentSurfer.Dto.User;
using EY.TalentSurfer.Services.Contracts;
using EY.TalentSurfer.Support;
using EY.TalentSurfer.Support.Exceptions;
using EY.TalentSurfer.Support.Persistence;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace EY.TalentSurfer.Services
{
    public class UserService : BaseService<RefreshToken, RefreshTokenCreateDto, RefreshTokenReadDto, RefreshTokenUpdateDto>, IUserService
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly AuthenticationSettings _authSettings;
        private readonly IPasswordHasher<User> _passwordHasher;

        public UserService(
            UserManager<User> userManager,
            SignInManager<User> signInManager,
            IMapper mapper,
            IOptions<AuthenticationSettings> options,
            IPasswordHasher<User> passwordHasher,
            IRepository<RefreshToken> repository) : base(repository, mapper)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _authSettings = options.Value;
            _passwordHasher = passwordHasher;
        }

        public AuthenticationProperties LoginWithGoogle()
        {
            return _signInManager.ConfigureExternalAuthenticationProperties("Google", "api/User/HandleLogin");
        }

        public async Task<UserSignedInDto> HandleLoginAsync()
        {
            var info = await _signInManager.GetExternalLoginInfoAsync();
            var result = await _signInManager.ExternalLoginSignInAsync(info.LoginProvider, info.ProviderKey, isPersistent: false);

            User user;

            if (result.Succeeded)
            {
                user = await _userManager.FindByLoginAsync(info.LoginProvider, info.ProviderKey);
            }
            else
            {
                var claimEmail = info.Principal.Claims.FirstOrDefault(p => p.Type == ClaimTypes.Email);
                user = await _userManager.FindByEmailAsync(claimEmail.Value);

                if (user == null)
                {
                    user = await CreateUser(info);
                }
                else
                {
                    await _userManager.AddLoginAsync(user, info);
                    var newUserClaims = info.Principal.Claims.Append(new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()));
                    await _userManager.AddClaimsAsync(user, newUserClaims);

                    await _userManager.SetLockoutEnabledAsync(user, true);

                }
            }

            var fullUser = _userManager.FindByIdAsync(user.Id.ToString());

            var claimsResult = _userManager.GetClaimsAsync(user);
            var claims = claimsResult.Result;

            var claimeRole = claims.FirstOrDefault(x => x.Type == ClaimTypes.Role);
            string role = "";
            if (claimeRole != null)
            {
                role = claimeRole.Value;
            }
            DateTime expirationDate = GetNextExpirationDate();

            string accessToken = GenerateJwtToken(
                user.Id.ToString(),
                user.UserName,
                user.ArchivingFlag ? "" : role,
                 expirationDate);

            return new UserSignedInDto
            {
                AccessToken = accessToken,
                AccessTokenExpiration = expirationDate,
                RefreshToken = await GenerateRefreshToken(user)
            };
        }

        public async Task<UserSignedInDto> HandleLoginAsync(string refreshToken, string accessToken)
        {
            var refreshTokenResult = await GetByTokenAsync(refreshToken);

            ValidateRefreshToken(refreshTokenResult);

            var tokenHandler = new JwtSecurityTokenHandler();
            JwtSecurityToken jwtToken = (JwtSecurityToken)tokenHandler.ReadToken(accessToken);

            DateTime expirationDate = GetNextExpirationDate();

            string newAccessToken = GenerateJwtToken(
                jwtToken.Claims.First(p => p.Type == "Id").Value,
                jwtToken.Claims.Single(p => p.Type == "nameid").Value,
                jwtToken.Claims.Single(p => p.Type == "role").Value,
                expirationDate);

            return new UserSignedInDto
            {
                AccessToken = newAccessToken,
                AccessTokenExpiration = expirationDate,
                RefreshToken = refreshToken
            };
        }

        private static void ValidateRefreshToken(RefreshTokenReadDto refreshTokenResult)
        {
            if (refreshTokenResult == null)
            {
                throw new RefreshTokenNotFoundException("Refresh token was not found.");
            }
            if (refreshTokenResult.Revoked)
            {
                throw new RefreshTokenDeniedException("Refresh token was revoked");
            }
        }

        public async Task<string> GenerateRefreshToken(User user)
        {
            string token = _passwordHasher.HashPassword(user, Guid.NewGuid().ToString())
                   .Replace("+", string.Empty)
                   .Replace("=", string.Empty)
                   .Replace("/", string.Empty);
            var refreshToken = new RefreshTokenCreateDto
            {
                Token = token,
                Username = user.UserName,
                Revoked = false
            };

            return (await GetByUserName(user.UserName) ?? await CreateAsync(refreshToken)).Token;
        }

        public async Task RevokeRefreshToken(string refreshToken)
        {
            var refreshTokenResult = await GetByTokenAsync(refreshToken);

            ValidateRefreshToken(refreshTokenResult);

            refreshTokenResult.Revoked = true;

            var updateRefreshToken = _mapper.Map<RefreshTokenUpdateDto>(refreshTokenResult);

            await UpdateAsync(refreshTokenResult.Id, updateRefreshToken);
        }

        private async Task<User> CreateUser(ExternalLoginInfo info)
        {
            var email = info.Principal.FindFirstValue(ClaimTypes.Email);
            var fullName = info.Principal.FindFirstValue(ClaimTypes.Name);

            var newUser = new User(email, fullName);

            var createResult = await _userManager.CreateAsync(newUser);
            if (!createResult.Succeeded)
                throw new UserException(createResult.Errors.Select(e => e.Description));

            await _userManager.AddLoginAsync(newUser, info);
            var newUserClaims = info.Principal.Claims.Append(new Claim(ClaimTypes.NameIdentifier, newUser.Id.ToString()));
            await _userManager.AddClaimsAsync(newUser, newUserClaims);

            await _userManager.SetLockoutEnabledAsync(newUser, true);


            return newUser;
        }

        public async Task<User> CreateUserAsync(UserCreateDto userDto)
        {
            var newUser = new User(userDto.Email, userDto.UserName);

            var createResult = await _userManager.CreateAsync(newUser);
            if (!createResult.Succeeded)
                throw new UserException(createResult.Errors.Select(e => e.Description));



            await _userManager.AddToRoleAsync(newUser, userDto.Role);
            await _userManager.AddClaimAsync(newUser, new Claim(ClaimTypes.Role, userDto.Role));

            return newUser;
        }

        public new async Task<IEnumerable<UserReadDto>> GetAllAsync()
        {
            var users = await _userManager.Users.ToListAsync();
            var userDtos = new List<UserReadDto>();
            foreach (var user in users)
            {
                var userDto = _mapper.Map<UserReadDto>(user);
                var role = (await _userManager.GetRolesAsync(user)).FirstOrDefault();
                if (!string.IsNullOrEmpty(role))
                {
                    userDto.Role = role;
                }
                userDtos.Add(userDto);
            }

            return userDtos;
        }

        public new async Task<UserReadDto> GetAsync(int id)
        {
            User user = await _userManager.FindByIdAsync(id.ToString());

            if (user == null) { return null; }

            var userDto = _mapper.Map<UserReadDto>(user);
            var role = (await _userManager.GetRolesAsync(user)).FirstOrDefault();

            if (!string.IsNullOrEmpty(role))
            {
                userDto.Role = role;
            }

            return userDto;
        }


        public async Task<User> UpdateAsync(int id, UserUpdateDTO userDTO)
        {
            var user = await _userManager.FindByIdAsync(id.ToString());

            user.ArchivingFlag = userDTO.ArchivingFlag;

            var userRoles = await _userManager.GetRolesAsync(user);
            var userClaims = await _userManager.GetClaimsAsync(user);

            if (!string.IsNullOrEmpty(userDTO.Role))
            {
                bool rolePresent = false;

                foreach (var userRole in userRoles)
                {
                    if (!userRole.Equals(userDTO.Role))
                    {
                        await _userManager.RemoveFromRoleAsync(user, userRole);
                    }
                    else
                    {
                        rolePresent = true;
                    }
                }

                if (!rolePresent)
                    await _userManager.AddToRoleAsync(user, userDTO.Role);

                bool claimPresent = false;

                foreach (var userClaim in userClaims.Where(x => x.Type == ClaimTypes.Role))
                {
                    if (!userClaim.Value.Equals(userDTO.Role))
                    {
                        await _userManager.RemoveClaimAsync(user, userClaim);
                    }
                    else
                    {
                        claimPresent = true;
                    }
                }

                if (!claimPresent)
                    await _userManager.AddClaimAsync(user, new Claim(ClaimTypes.Role, userDTO.Role));
            }

            var updateResult = await _userManager.UpdateAsync(user);
            if (!updateResult.Succeeded)
                throw new UserException(updateResult.Errors.Select(e => e.Description));

            return user;
        }


        private string GenerateJwtToken(string userId, string userName, string role, DateTime expirationDate)
        {
            var key = Encoding.UTF8.GetBytes(_authSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(PrivateClaimTypes.Id, userId),
                    new Claim(ClaimTypes.NameIdentifier, userName),
                    new Claim(ClaimTypes.Role, role),
                }),
                Expires = expirationDate,
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256)
            };
            var tokenHandler = new JwtSecurityTokenHandler();
            var securityToken = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(securityToken);
        }

        private DateTime GetNextExpirationDate()
        {
            return DateTime.UtcNow.AddMinutes(_authSettings.TokenDuration);
        }

        public async Task<bool> UserExists(int userId)
        {
            return await _userManager.Users.AnyAsync(u => u.Id == userId);
        }

        private async Task<RefreshTokenReadDto> GetByTokenAsync(string token)
        {
            return _mapper.Map<RefreshTokenReadDto>(await _repository.SingleOrDefaultAsync(p => p.Token == token));
        }

        private async Task<RefreshTokenReadDto> GetByUserName(string username)
        {
            if (await _repository.AnyAsync(p => p.Username == username))
            {
                RefreshToken refreshToken = await _repository.SingleOrDefaultAsync(p => p.Username == username);
                refreshToken.Revoked = false;
                await _repository.UpdateAsync(refreshToken);
                return _mapper.Map<RefreshTokenReadDto>(refreshToken);
            }
            return null;
        }
    }
}
