using AutoMapper;
using EY.TalentSurfer.Domain;
using EY.TalentSurfer.Dto.SOW;
using EY.TalentSurfer.Services.Contracts;
using EY.TalentSurfer.Support.Persistence;

namespace EY.TalentSurfer.Services
{
    public class SowService : BaseService<Sow, SowCreateDto, SowReadDto, SowUpdateDto>, ISowService
    {
        public SowService(IRepository<Sow> repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
