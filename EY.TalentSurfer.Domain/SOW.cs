using EY.TalentSurfer.Support.Persistence;

namespace EY.TalentSurfer.Domain
{
    public class Sow : AuditableEntity
    {
        public string Name { get; set; }
        public bool ArchivingFlag { get; set; }
        public string Comments { get; set; }
    }
}
