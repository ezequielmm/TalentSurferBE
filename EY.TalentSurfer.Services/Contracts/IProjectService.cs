using EY.TalentSurfer.Domain;
using EY.TalentSurfer.Dto;

namespace EY.TalentSurfer.Services.Contracts
{
    public interface IProjectService : IBaseService<Project, ProjectCreateDto, ProjectReadDto, ProjectUpdateDto>
    {
    }
}
