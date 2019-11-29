using EY.TalentSurfer.Domain;
using EY.TalentSurfer.Dto;
using System.Threading.Tasks;

namespace EY.TalentSurfer.Services.Contracts
{
    public interface IPositionStatusService : IBaseService<PositionStatus, PositionStatusCreateDto, PositionStatusReadDto, PositionStatusUpdateDto>
    {       
    }
}