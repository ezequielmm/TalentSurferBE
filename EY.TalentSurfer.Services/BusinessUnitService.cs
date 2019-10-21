using AutoMapper;
using EY.TalentSurfer.Domain;
using EY.TalentSurfer.Dto;
using EY.TalentSurfer.Services.Contracts;
using EY.TalentSurfer.Support.Persistence;

namespace EY.TalentSurfer.Services
{
    public class BusinessUnitService : 
        BaseService<BusinessUnit, BusinessUnitCreateDto, BusinessUnitReadDto, BusinessUnitUpdateDto>, IBusinessUnitService
    {
        public BusinessUnitService(IRepository<BusinessUnit> repository, IMapper mapper) : base(repository, mapper)
        {            
        }
    }
}
