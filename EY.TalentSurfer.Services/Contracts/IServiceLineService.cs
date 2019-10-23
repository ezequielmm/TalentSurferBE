using EY.TalentSurfer.Domain;
using EY.TalentSurfer.Dto;

namespace EY.TalentSurfer.Services.Contracts
{
    public interface IServiceLineService : IBaseService<ServiceLine, ServiceLineCreateDto, ServiceLineReadDto, ServiceLineUpdateDto>
    {
    }
}