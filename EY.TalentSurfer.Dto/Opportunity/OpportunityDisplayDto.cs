using EY.TalentSurfer.Support.Services.Contracts;
using System;

namespace EY.TalentSurfer.Dto
{
    public class OpportunityDisplayDto : IReadDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Owner { get; set; }

        public string Status { get; set; }

        public DateTime StartDate { get; set; }
    }
}
