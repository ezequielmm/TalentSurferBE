using AutoMapper;
using EY.TalentSurfer.Domain;
using EY.TalentSurfer.Dto;
using EY.TalentSurfer.Services.Contracts;
using EY.TalentSurfer.Support.Persistence;

namespace EY.TalentSurfer.Services
{
    public class CertaintyService : 
        BaseService<Certainty, CertaintyCreateDto, CertaintyReadDto, CertaintyUpdateDto>, ICertaintyService
    {
        public CertaintyService(IRepository<Certainty> repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
