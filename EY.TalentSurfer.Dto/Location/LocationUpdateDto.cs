﻿using EY.TalentSurfer.Support.Services.Contracts;
using System.ComponentModel.DataAnnotations;

namespace EY.TalentSurfer.Dto
{
    public class LocationUpdateDto : IUpdateDto
    {
        [Required]
        [MaxLength(1000)]
        public string Description { get; set; }

        [Required]
        public bool ArchivingFlag { get; set; }

        [MaxLength(1000)]
        public string Comments { get; set; }
    }
}
