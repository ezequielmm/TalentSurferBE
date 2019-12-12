using EY.TalentSurfer.Support.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace EY.TalentSurfer.Dto.PositionSlot
{
   public class PositionSlotReadDto : IReadDto
    {
        public int Id { get; set; }
        public IEnumerable<int> AdditionalLocationsIds { get; set; }
        public string Glober { get; set; }
        public string GloberEmail { get; set; }
        public string Tickets { get; set; }

        public string NonGlober { get; set; }
        public string NonGloberEmail { get; set; }

        public int? PositionId { get; set; }
        public int? SeniorityId { get; set; }
        public int? LocationId { get; set; }

        public int? PostionStatusId { get; set; }
        public int? CandidateSeniorityId { get; set; }
        public int? CandidateLocationId { get; set; }
    }
}
