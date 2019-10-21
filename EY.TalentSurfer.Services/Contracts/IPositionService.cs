using EY.TalentSurfer.Domain;
using EY.TalentSurfer.Dto;

namespace EY.TalentSurfer.Services.Contracts
{
    public interface IPositionService : IBaseService<Position, PositionCreateDto, PositionReadDto, PositionUpdateDto>
    {
    }
}