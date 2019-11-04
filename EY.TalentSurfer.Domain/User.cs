using System;
using Microsoft.AspNetCore.Identity;

namespace EY.TalentSurfer.Domain
{
    public class 
        User : IdentityUser<int>
    {
        private User()
        {

        }

        public User(string email, string fullName)
        {
            UserName = email.Split('@')[0];
            Email = email;
            FullName = fullName;
            Status = UserStatus.Submitted;
            EmailConfirmed = true;
        }

        public string FullName { get; protected set; }

        public UserStatus Status { get; protected set; }

        public void Approve()
        {
            this.Status = UserStatus.Approved;
        }

        public void Reject()
        {
            this.Status = UserStatus.Rejected;
        }
    }
}
