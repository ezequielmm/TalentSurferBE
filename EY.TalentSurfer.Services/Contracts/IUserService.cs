using EY.TalentSurfer.Domain;
using EY.TalentSurfer.Dto;
using EY.TalentSurfer.Dto.User;
using Microsoft.AspNetCore.Authentication;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EY.TalentSurfer.Services.Contracts
{
    public interface IUserService
    {
        AuthenticationProperties LoginWithGoogle();
        Task<UserSignedInDto> HandleLoginAsync();
        Task<UserSignedInDto> HandleLoginAsync(string refreshToken, string accessToken);
        Task<UserReadDto> GetAsync(int id);
        Task<IEnumerable<UserReadDto>> GetAllAsync();

        Task<User> UpdateAsync(int id, UserUpdateDTO userDTO);
        Task<bool> UserExists(int userId);
        Task RevokeRefreshToken(string refreshToken);
    }
}
