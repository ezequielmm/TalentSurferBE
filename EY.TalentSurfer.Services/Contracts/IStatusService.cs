using EY.TalentSurfer.Domain;
using EY.TalentSurfer.Dto;

namespace EY.TalentSurfer.Services.Contracts
{
    public interface IStatusService : IBaseService<Status, StatusCreateDto, StatusReadDto, StatusUpdateDto>
    {
    }
}