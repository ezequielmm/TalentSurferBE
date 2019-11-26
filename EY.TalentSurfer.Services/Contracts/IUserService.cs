using EY.TalentSurfer.Domain;
using EY.TalentSurfer.Dto.RefreshToken;
using EY.TalentSurfer.Dto.User;
using Microsoft.AspNetCore.Authentication;
using System.Threading.Tasks;

namespace EY.TalentSurfer.Services.Contracts
{
    public interface IUserService
    {
        AuthenticationProperties LoginWithGoogle();
        Task<UserSignedInDto> HandleLoginAsync();
        Task<UserSignedInDto> HandleLoginAsync(string refreshToken, string accessToken);
        Task ApproveUserAsync(int userId);
        Task RejectUserAsync(int userId);
        Task<bool> UserExists(int userId);
        Task RevokeRefreshToken(string refreshToken);
    }
}
