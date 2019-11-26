using EY.TalentSurfer.Support.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EY.TalentSurfer.Domain
{
    public class Opportunity : AuditableEntity
    {
        public string Name { get; protected set; }

        public DateTime StartDate { get; protected set; }

        public DateTime EndDate { get; protected set; }

        public IEnumerable<Location> AdditionalLocations => _additionalOpportunityLocations.Select(l => l.Location);

        public IEnumerable<OpportunityLocation> AdditionalOpportunityLocations => _additionalOpportunityLocations;

        protected IEnumerable<OpportunityLocation> _additionalOpportunityLocations;

        public string Product { get; protected set; }

        public int? ProjectId { get; protected set; }

        public Project Project { get; protected set; }

        public string HiringManager { get; protected set; }

        public string EyId { get; protected set; }

        public string Contact { get; protected set; }

        public string Owner { get; protected set; } // TODO: this is temporarily a string until Globers table and model are created

        public Certainty Certainty { get; protected set; }
        public int? CertaintyId { get; protected set; }

        public Location PrimaryLocation { get; protected set; }
        public int? PrimaryLocationId { get; protected set; }

        public string ProposalFolder { get; protected set; }

        public int Sow { get; protected set; } // TODO: check if we are saving just sow number or an entity

        public ServiceLine ServiceLine { get; protected set; }
        public int? ServiceLineId { get; protected set; }

        public string RequestedByName { get; protected set; }

        public string RequestedByEmail { get; protected set; }

        public DateTime RequestedOn { get; protected set; }


        public Opportunity Map { get; protected set; }
        public int? MapId { get; protected set; }

        public Status Status { get; protected set; }
        public int? StatusId { get; protected set; }

        public string OriginalOpptCopy { get; protected set; }

        private Opportunity() { }

        public Opportunity(string name, DateTime startDate, DateTime endDate)
        {
            Name = name;
            StartDate = startDate;
            EndDate = endDate;
            _additionalOpportunityLocations = new List<OpportunityLocation>();
        }

        public void UpdateLocations(IEnumerable<int> locationsids)
        {
            var listAdditionalOpportunityLocations = _additionalOpportunityLocations.ToList();
            listAdditionalOpportunityLocations.RemoveAll(l => !locationsids.Contains(l.LocationId));
            if (locationsids != null)
            {
                listAdditionalOpportunityLocations.AddRange(locationsids
                        .Where(locationId => !listAdditionalOpportunityLocations.Any(l => l.LocationId == locationId))
                        .Select(locationId => new OpportunityLocation(Id, locationId)));
            }
            _additionalOpportunityLocations = listAdditionalOpportunityLocations.AsEnumerable();
        }
    }
}
