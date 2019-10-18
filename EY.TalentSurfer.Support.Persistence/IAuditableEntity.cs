using System;

namespace EY.TalentSurfer.Support.Persistence
{
    public interface IAuditableEntity : IEntity
    {
        string CreatedBy { get; set; }
        DateTimeOffset CreatedOn { get; set; }
        string ModifiedBy { get; set; }
        DateTimeOffset ModifiedOn { get; set; }
    }
}
