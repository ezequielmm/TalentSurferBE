using EY.TalentSurfer.Domain;
using EY.TalentSurfer.Dto.SOW;

namespace EY.TalentSurfer.Services.Contracts
{
    public interface ISowService : IBaseService<Sow, SowCreateDto, SowReadDto, SowUpdateDto>
    {
    }
}
