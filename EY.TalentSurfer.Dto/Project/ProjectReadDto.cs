using EY.TalentSurfer.Support.Services.Contracts;

namespace EY.TalentSurfer.Dto
{
    public class ProjectReadDto : IReadDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool ArchivingFlag { get; set; }
        public string Comments { get; set; }
    }
}
