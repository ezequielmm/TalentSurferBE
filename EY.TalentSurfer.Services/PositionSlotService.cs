using AutoMapper;
using EY.TalentSurfer.Domain;
using EY.TalentSurfer.Dto.PositionSlot;
using EY.TalentSurfer.Services.Contracts;
using EY.TalentSurfer.Support.Persistence.Sql.PositionsSlot;

namespace EY.TalentSurfer.Services
{
    public class PositionSlotService : BaseService<PositionSlot, PositionSlotCreateDto, PositionSlotReadDto, PositionSlotUpdateDto>, IPositionSlotService
    {
       
        public PositionSlotService(IPositionSlotRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
