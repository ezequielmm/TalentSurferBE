using EY.TalentSurfer.Support.Services.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EY.TalentSurfer.Dto
{
    public abstract class OpportunityBaseDto : ICreateDto
    {
        [Required]
        public string Name { get; set; }

        public string Product { get; set; }

        public string ProjectName { get; set; }

        public string Owner { get; set; } // TODO: this is temporarily a string until Globers table and model are created

        public int? CertaintyId { get; set; }

        public int? PrimaryLocationId { get; set; }

        public string ProposalFolder { get; set; }

        public int Sow { get; set; }

        public int? ServiceLineId { get; set; }

        public string RequestedByName { get; set; }

        public string RequestedByEmail { get; set; }

        public DateTime RequestedOn { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        public IEnumerable<int> AdditionalLocationsIds { get; set; }

        public int? MapId { get; set; }

        public int? StatusId { get; set; }

        public string OriginalOpptCopy { get; set; }
    }
}
