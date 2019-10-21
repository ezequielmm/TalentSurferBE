using EY.TalentSurfer.Domain;
using EY.TalentSurfer.Dto;

namespace EY.TalentSurfer.Services.Contracts
{
    public interface IPositionStatusService : IBaseService<PositionStatus, PositionStatusCreateDto, PositionStatusReadDto, PositionStatusUpdateDto>
    {
    }
}