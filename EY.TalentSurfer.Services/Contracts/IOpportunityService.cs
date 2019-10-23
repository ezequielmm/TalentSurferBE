using EY.TalentSurfer.Domain;
using EY.TalentSurfer.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EY.TalentSurfer.Services.Contracts
{
    public interface IOpportunityService : IBaseService<Opportunity, OpportunityCreateDto, OpportunityReadDto, OpportunityUpdateDto>
    {
        new Task<IEnumerable<OpportunityDisplayDto>> GetAllAsync();
    }
}
