using EY.TalentSurfer.Support.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace EY.TalentSurfer.Dto.PositionSlot
{
  public class PositionSlotDisplayDto : IReadDto
    {
        public int Id { get; set; }
        public string Glober { get; set; }
        public string GloberEmail { get; set; }
        public int? PositionId { get; set; }
        public int? SeniorityId { get; set; }
        public int? LocationId { get; set; }

    }
}
