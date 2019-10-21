using EY.TalentSurfer.Domain;
using EY.TalentSurfer.Dto;

namespace EY.TalentSurfer.Services.Contracts
{
    public interface IBusinessUnitService : IBaseService<BusinessUnit, BusinessUnitCreateDto, BusinessUnitReadDto, BusinessUnitUpdateDto>
    {
    }
}