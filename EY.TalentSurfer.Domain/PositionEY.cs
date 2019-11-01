﻿using EY.TalentSurfer.Support.Persistence;

namespace EY.TalentSurfer.Domain
{
    public class PositionEY : AuditableEntity
    {
        public string Name { get; protected set; }
        public bool ArchivingFlag { get; protected set; }
        public string Comments { get; protected set; }
    }
}
