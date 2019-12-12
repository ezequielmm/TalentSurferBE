using EY.TalentSurfer.Domain;
using EY.TalentSurfer.Dto.PositionSlot;
using System;
using System.Collections.Generic;
using System.Text;

namespace EY.TalentSurfer.Services.Contracts
{
   public interface IPositionSlotService : IBaseService<PositionSlot, PositionSlotCreateDto, PositionSlotReadDto, PositionSlotUpdateDto>
    {

    }
}
