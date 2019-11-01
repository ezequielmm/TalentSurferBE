using EY.TalentSurfer.Support.Persistence;
using System;

namespace EY.TalentSurfer.Domain
{
    public class PositionStatus : AuditableEntity
    {
        private PositionStatus()
        {

        }
        public PositionStatus(int id, string description, DateTime createdOn, string createdBy)
        {
            Id = id;
            Description = description;
            CreatedOn = createdOn;
            CreatedBy = createdBy;
        }
        public string Description { get; protected set; }
        public bool ArchivingFlag { get; protected set; }
        public string Comments { get; protected set; }
    }
}
