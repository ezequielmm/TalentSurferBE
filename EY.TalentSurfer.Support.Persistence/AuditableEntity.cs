using System;

namespace EY.TalentSurfer.Support.Persistence
{
    public class AuditableEntity : Entity, IAuditableEntity
    {
        public string CreatedBy { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset ModifiedOn { get; set; }
    }
}
