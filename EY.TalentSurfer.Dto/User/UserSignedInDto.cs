using System;

namespace EY.TalentSurfer.Dto.User
{
    public class UserSignedInDto
    {
        public string AccessToken { get; set; }
        public DateTime AccessTokenExpiration { get; set; }
        public string RefreshToken { get; set; }
    }
}
