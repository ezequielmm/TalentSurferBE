using AutoMapper;
using EY.TalentSurfer.Domain;
using EY.TalentSurfer.Dto;
using EY.TalentSurfer.Services.Contracts;
using EY.TalentSurfer.Support.Persistence;

namespace EY.TalentSurfer.Services
{
    public class SeniorityService : 
        BaseService<Seniority, SeniorityCreateDto, SeniorityReadDto, SeniorityUpdateDto>, ISeniorityService
    {
        public SeniorityService(IRepository<Seniority> repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
