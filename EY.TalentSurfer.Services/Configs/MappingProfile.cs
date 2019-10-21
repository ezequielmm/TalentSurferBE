using AutoMapper;
using EY.TalentSurfer.Domain;
using EY.TalentSurfer.Dto;

namespace EY.TalentSurfer.Services.Configs
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Add as many of these lines as you need to map your objects
            CreateMap<BusinessUnit, BusinessUnitReadDto>();
            CreateMap<BusinessUnitCreateDto, BusinessUnit>();
            CreateMap<BusinessUnitUpdateDto, BusinessUnit>();
            CreateMap<Location, LocationReadDto>();
            CreateMap<LocationCreateDto, Location>();
            CreateMap<LocationUpdateDto, Location>();
            CreateMap<Certainty, CertaintyReadDto>();
            CreateMap<CertaintyCreateDto, Certainty>();
            CreateMap<CertaintyUpdateDto, Certainty>();
        }
    }
}
