using EY.TalentSurfer.Support.Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace EY.TalentSurfer.Domain
{
    public class AspNetRoles : AuditableEntity
    {
        private AspNetRoles()
        {

        }
        public AspNetRoles(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public string Name { get; protected set; }
    }
}
