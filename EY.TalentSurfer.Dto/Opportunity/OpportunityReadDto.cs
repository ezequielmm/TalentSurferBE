using EY.TalentSurfer.Support.Services.Contracts;

namespace EY.TalentSurfer.Dto
{
    public class OpportunityReadDto : OpportunityBaseDto, IReadDto
    {
        public int Id { get; set; }
    }
}
