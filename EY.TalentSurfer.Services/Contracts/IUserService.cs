using Microsoft.AspNetCore.Authentication;
using System.Threading.Tasks;

namespace EY.TalentSurfer.Services.Contracts
{
    public interface IUserService
    {
        AuthenticationProperties LoginWithGoogle();
        Task<string> HandleLoginAsync();
    }
}
