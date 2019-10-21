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
            CreateMap<Seniority, SeniorityReadDto>();
            CreateMap<SeniorityCreateDto, Seniority>();
            CreateMap<SeniorityUpdateDto, Seniority>();
            CreateMap<Certainty, CertaintyReadDto>();
            CreateMap<CertaintyCreateDto, Certainty>();
            CreateMap<CertaintyUpdateDto, Certainty>();
            CreateMap<Status, StatusReadDto>();
            CreateMap<StatusCreateDto, Status>();
            CreateMap<StatusUpdateDto, Status>();
            CreateMap<Position, PositionReadDto>();
            CreateMap<PositionCreateDto, Position>();
            CreateMap<PositionUpdateDto, Position>();
            CreateMap<PositionStatus, PositionStatusReadDto>();
            CreateMap<PositionStatusCreateDto, PositionStatus>();
            CreateMap<PositionStatusUpdateDto, PositionStatus>();
        }
    }
}
