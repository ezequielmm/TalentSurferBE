using EY.TalentSurfer.Domain;
using EY.TalentSurfer.Dto;

namespace EY.TalentSurfer.Services.Contracts
{
    public interface ILocationService : IBaseService<Location, LocationCreateDto, LocationReadDto, LocationUpdateDto>
    {
    }
}
