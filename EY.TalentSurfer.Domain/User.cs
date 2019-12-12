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
            EmailConfirmed = true;
            ArchivingFlag = false;
        }

        public bool ArchivingFlag { get; set; }

        public string FullName { get; protected set; }

     
    }
}
