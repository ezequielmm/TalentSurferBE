using AutoMapper;
using EY.TalentSurfer.Domain;
using EY.TalentSurfer.Dto;
using EY.TalentSurfer.Services.Contracts;
using EY.TalentSurfer.Support.Persistence;

namespace EY.TalentSurfer.Services
{
    public class LocationService : 
        BaseService<Location, LocationCreateDto, LocationReadDto, LocationUpdateDto>, ILocationService
    {
        public LocationService(IRepository<Location> repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
