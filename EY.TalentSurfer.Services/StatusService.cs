using AutoMapper;
using EY.TalentSurfer.Domain;
using EY.TalentSurfer.Dto;
using EY.TalentSurfer.Services.Contracts;
using EY.TalentSurfer.Support.Persistence;

namespace EY.TalentSurfer.Services
{
    public class StatusService : 
        BaseService<Status, StatusCreateDto, StatusReadDto, StatusUpdateDto>, IStatusService
    {
        public StatusService(IRepository<Status> repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
