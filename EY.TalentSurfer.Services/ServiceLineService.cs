using AutoMapper;
using EY.TalentSurfer.Domain;
using EY.TalentSurfer.Dto;
using EY.TalentSurfer.Services.Contracts;
using EY.TalentSurfer.Support.Persistence;

namespace EY.TalentSurfer.Services
{
    public class ServiceLineService : BaseService<ServiceLine, ServiceLineCreateDto, ServiceLineReadDto, ServiceLineUpdateDto>, IServiceLineService
    {
        public ServiceLineService(IRepository<ServiceLine> repository, IMapper mapper) : base(repository, mapper)
        {            
        }
    }
}
