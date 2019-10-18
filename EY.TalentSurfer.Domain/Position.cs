using EY.TalentSurfer.Support.Persistence;

namespace EY.TalentSurfer.Domain
{
    public class Position : AuditableEntity
    {
        public int SortOrder { get; set; }
        public string Description { get; set; }
        public bool ArchivingFlag { get; set; }
        public string Comments { get; set; }
    }
}
