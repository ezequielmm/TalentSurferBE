using EY.TalentSurfer.Domain;
using EY.TalentSurfer.Dto;

namespace EY.TalentSurfer.Services.Contracts
{
    public interface ISeniorityService : IBaseService<Seniority, SeniorityCreateDto, SeniorityReadDto, SeniorityUpdateDto>
    {
    }
}