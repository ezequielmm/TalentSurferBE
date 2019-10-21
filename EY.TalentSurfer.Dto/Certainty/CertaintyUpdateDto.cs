using EY.TalentSurfer.Support.Services.Contracts;

namespace EY.TalentSurfer.Dto
{
    public class CertaintyUpdateDto : IUpdateDto
    {
        public int SortOrder { get; set; }
        public string Description { get; set; }
        public string Value { get; set; }
        public bool ArchivingFlag { get; set; }
        public string Comments { get; set; }
    }
}
