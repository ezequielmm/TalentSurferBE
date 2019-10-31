using Microsoft.AspNetCore.Identity;

namespace EY.TalentSurfer.Domain
{
    public class User : IdentityUser<int>
    {
        public User()
        {
            Status = UserStatus.Submitted;
        }

        public string FullName { get; set; }

        public UserStatus Status { get; set; }

    }
}
