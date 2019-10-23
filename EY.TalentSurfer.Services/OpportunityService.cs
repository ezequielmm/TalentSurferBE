using AutoMapper;
using EY.TalentSurfer.Domain;
using EY.TalentSurfer.Dto;
using EY.TalentSurfer.Services.Contracts;
using EY.TalentSurfer.Support.Persistence.Sql;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EY.TalentSurfer.Services
{
    public class OpportunityService : BaseService<Opportunity, OpportunityCreateDto, OpportunityReadDto, OpportunityUpdateDto>, IOpportunityService
    {
        public OpportunityService(IOpportunityRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }

        public new async Task<IEnumerable<OpportunityDisplayDto>> GetAllAsync()
        {
            var entities = await _repository.ToListAsync();
            return _mapper.Map<IEnumerable<OpportunityDisplayDto>>(entities);
        }
    }
}

