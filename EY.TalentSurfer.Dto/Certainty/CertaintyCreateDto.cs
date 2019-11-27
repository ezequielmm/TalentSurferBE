using EY.TalentSurfer.Support.Services.Contracts;
using System.ComponentModel.DataAnnotations;

namespace EY.TalentSurfer.Dto
{
    public class CertaintyCreateDto : ICreateDto
    {
        [Required]
        [StringLength(1000)]
        public string Description { get; set; }
        [Required]
        [StringLength(1000)]
        public string Value { get; set; }
        public bool ArchivingFlag { get; set; }
        [Required]
        [StringLength(1000)]
        public string Comments { get; set; }
    }
}
