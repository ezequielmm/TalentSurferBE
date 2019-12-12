using EY.TalentSurfer.Support.Services.Contracts;

namespace EY.TalentSurfer.Dto
{
    public class UserReadDto : IReadDto
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public bool ArchivingFlag { get; set; }
    }
}
