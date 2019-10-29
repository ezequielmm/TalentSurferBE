using AutoMapper;
using EY.TalentSurfer.Domain;
using EY.TalentSurfer.Dto;
using EY.TalentSurfer.Services.Contracts;
using EY.TalentSurfer.Support.Persistence;

namespace EY.TalentSurfer.Services
{
    public class ProjectService : 
        BaseService<Project, ProjectCreateDto, ProjectReadDto, ProjectUpdateDto>, IProjectService
    {
        public ProjectService(IRepository<Project> repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
