using AutoMapper;
using EY.TalentSurfer.Domain;
using EY.TalentSurfer.Dto;
using EY.TalentSurfer.Services.Contracts;
using EY.TalentSurfer.Support.Persistence;

namespace EY.TalentSurfer.Services
{
    public class PositionStatusService : 
        BaseService<PositionStatus, PositionStatusCreateDto, PositionStatusReadDto, PositionStatusUpdateDto>, IPositionStatusService
    {
        public PositionStatusService(IRepository<PositionStatus> repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
