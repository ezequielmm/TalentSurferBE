﻿
using EY.TalentSurfer.Support.Services.Contracts;
using System.ComponentModel.DataAnnotations;

namespace EY.TalentSurfer.Dto.SOW
{
    public class SowUpdateDto : IUpdateDto
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        public bool ArchivingFlag { get; set; }

        [MaxLength(1000)]
        public string Comments { get; set; }
    }
}
