using System;
using System.Collections.Generic;
using System.Text;
using EY.TalentSurfer.Support.Persistence;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace EY.TalentSurfer.Domain
{
    public class PositionSlot : AuditableEntity
    {
        public IEnumerable<Location> AdditionalLocations => _additionalPositionSlotLocations.Select(l => l.Location);

        public IEnumerable<PositionSlotLocation> AdditionalPositionSlotLocations => _additionalPositionSlotLocations;

        protected IEnumerable<PositionSlotLocation> _additionalPositionSlotLocations;

        public string Glober{ get; set; }
        public string GloberEmail { get; set; }       
        public string Tickets { get; set; }
        public string NonGlober { get; set; }
        public string NonGloberEmail { get; set; }      
        public Position Position { get; protected set; }       
        public int? PositionId { get; protected set; }
        public Seniority Seniority { get; protected set; }
        public int? SeniorityId { get; protected set; }
        public Location Location { get; protected set; }
        public int? LocationId { get; protected set; }
        public PositionStatus PositionStatus { get; protected set; }
        public int? PostionStatusId { get; protected set; }       
        public Seniority CandidateSeniority { get; protected set; }       
        public int? CandidateSeniorityId { get; protected set; }
        public Location CandidateLocation { get; protected set; }       
        public int? CandidateLocationId { get; protected set; }
        private PositionSlot() { }

        public PositionSlot(int positionId, int seniorityId, int locationId)
        {
            PositionId = positionId;
            SeniorityId = seniorityId;
            LocationId = locationId;
            _additionalPositionSlotLocations = new List<PositionSlotLocation>();
        }
        public void UpdateLocations(IEnumerable<int> locationsids)
        {
            var listAdditionalPositionSlotLocations = _additionalPositionSlotLocations.ToList();
            listAdditionalPositionSlotLocations.RemoveAll(l => !locationsids.Contains(l.LocationId));
            if (locationsids != null)
            {
                listAdditionalPositionSlotLocations.AddRange(locationsids
                        .Where(locationId => !listAdditionalPositionSlotLocations.Any(l => l.LocationId == locationId))
                        .Select(locationId => new PositionSlotLocation(Id, locationId)));
            }
            _additionalPositionSlotLocations = listAdditionalPositionSlotLocations.AsEnumerable();
        }

    }
}


