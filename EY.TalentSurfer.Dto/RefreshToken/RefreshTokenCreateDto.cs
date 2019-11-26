using System;
using System.Collections.Generic;
using System.Text;
using EY.TalentSurfer.Support.Services.Contracts;

namespace EY.TalentSurfer.Dto.RefreshToken
{
    public class RefreshTokenCreateDto : ICreateDto
    {
        public string Username { get; set; }
        public string Token { get; set; }
        public bool Revoked { get; set; }
    }
}
