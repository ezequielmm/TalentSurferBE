using EY.TalentSurfer.Support.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EY.TalentSurfer.Domain
{
    public class Opportunity : AuditableEntity
    {
        public string Name { get; private set; }

        public DateTime StartDate { get; private set; }

        public DateTime EndDate { get; private set; }

        public IEnumerable<Location> AdditionalLocations => _additionalOpportunityLocations.Select(l => l.Location);

        public IEnumerable<OpportunityLocation> AdditionalOpportunityLocations => _additionalOpportunityLocations;

        protected IEnumerable<OpportunityLocation> _additionalOpportunityLocations;

        public string Product { get; set; }

        public string ProjectName { get; set; }

        public string Owner { get; set; } // TODO: this is temporarily a string until Globers table and model are created

        public Certainty Certainty { get; set; }
        public int? CertaintyId { get; set; }

        public Location PrimaryLocation { get; set; }
        public int? PrimaryLocationId { get; set; }

        public string ProposalFolder { get; set; }

        public int Sow { get; set; } // TODO: check if we are saving just sow number or an entity

        public ServiceLine ServiceLine { get; set; }
        public int? ServiceLineId { get; set; }

        public string RequestedByName { get; set; }

        public string RequestedByEmail { get; set; }

        public DateTime RequestedOn { get; set; }


        public Opportunity Map { get; set; }
        public int? MapId { get; set; }

        public Status Status { get; set; }
        public int? StatusId { get; set; }

        public string OriginalOpptCopy { get; set; }

        protected Opportunity() { }

        public Opportunity(string name, DateTime startDate, DateTime endDate)
        {
            Name = name;
            StartDate = startDate;
            EndDate = endDate;
            _additionalOpportunityLocations = new List<OpportunityLocation>();
        }

        public void UpdateLocations(IEnumerable<int> locationsids)
        {
            _additionalOpportunityLocations.ToList().RemoveAll(l => !locationsids.Contains(l.LocationId));
            _additionalOpportunityLocations.ToList().AddRange(locationsids
                    .Where(locationId => !_additionalOpportunityLocations.Select(a => a.LocationId).Contains(locationId))
                    .Select(locationId => new OpportunityLocation(Id, locationId)));

        }
    }
}
