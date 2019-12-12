using EY.TalentSurfer.Support.Services.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EY.TalentSurfer.Dto.User
{
    public class UserUpdateDTO : IUpdateDto
    {
        public string Role { get; set; }
        [Required]
        public bool ArchivingFlag { get; set; }
    }
}
