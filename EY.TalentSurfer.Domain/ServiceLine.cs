using EY.TalentSurfer.Support.Persistence;
using System;

namespace EY.TalentSurfer.Domain
{
    public class ServiceLine : AuditableEntity
    {
        private ServiceLine()
        {

        }
        public ServiceLine(int id, string description, DateTime createdOn, string createdBy)
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
