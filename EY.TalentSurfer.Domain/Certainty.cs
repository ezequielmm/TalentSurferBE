using EY.TalentSurfer.Support.Persistence;
using System;

namespace EY.TalentSurfer.Domain
{
    public class Certainty : AuditableEntity
    {
        private Certainty()
        {

        }
        public Certainty(int id, string description,string value, DateTime createdOn, string createdBy)
        {
            Id = id;
            Description = description;
            Value = value;
            CreatedOn = createdOn;
            CreatedBy = createdBy;
        }
        public string Description { get; protected set; }
        public string Value { get; protected set; }
        public bool ArchivingFlag { get; protected set; }
        public string Comments { get; protected set; }
    }
}
