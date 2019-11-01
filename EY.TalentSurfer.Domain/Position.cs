using EY.TalentSurfer.Support.Persistence;
using System;

namespace EY.TalentSurfer.Domain
{
    public class Position : AuditableEntity
    {
        private Position()
        {

        }

        public Position(int id, string description, DateTime createdOn, string createdBy)
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
