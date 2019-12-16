using AutoMapper;
using EY.TalentSurfer.Domain;
using EY.TalentSurfer.Dto;
using EY.TalentSurfer.Dto.PositionSlot;
using EY.TalentSurfer.Dto.RefreshToken;
using EY.TalentSurfer.Dto.Roles;
using EY.TalentSurfer.Dto.SOW;
using Microsoft.AspNetCore.Identity;
using System.Linq;

namespace EY.TalentSurfer.Services.Configs
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Add as many of these lines as you need to map your objects
            CreateMap<ServiceLine, ServiceLineReadDto>();
            CreateMap<ServiceLineCreateDto, ServiceLine>();
            CreateMap<ServiceLineUpdateDto, ServiceLine>();
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
            CreateMap<Project, ProjectReadDto>();
            CreateMap<ProjectCreateDto, Project>();
            CreateMap<ProjectUpdateDto, Project>();
            CreateMap<PositionEY, PositionEYReadDto>();
            CreateMap<PositionEYCreateDto, PositionEY>();
            CreateMap<PositionEYUpdateDto, PositionEY>();
            CreateMap<Sow, SowReadDto>();
            CreateMap<SowCreateDto, Sow>();
            CreateMap<SowUpdateDto, Sow>();
            CreateMap<RefreshTokenCreateDto, RefreshToken>();
            CreateMap<RefreshTokenUpdateDto, RefreshToken>();
            CreateMap<RefreshToken, RefreshTokenReadDto>();
            CreateMap<RefreshTokenReadDto, RefreshTokenUpdateDto>();
            CreateMap<User, UserReadDto>();


            OpportunityMapping();
            RoleMapping();
            PositionSlotMapping();
        }

        private void OpportunityMapping()
        {
            CreateMap<Opportunity, OpportunityReadDto>()
                .ForMember(
                    e => e.AdditionalLocationsIds,
                    m => m.MapFrom(o => o.AdditionalOpportunityLocations.Select(l => l.LocationId))
                );
            CreateMap<Opportunity, OpportunityDisplayDto>()
                .ForMember(
                    e => e.Status,
                    m => m.MapFrom(o => o.Status != null ? o.Status.Description : string.Empty)
                );
            CreateMap<OpportunityCreateDto, Opportunity>()
                .ConstructUsing(d => new Opportunity(d.Name, d.StartDate, d.EndDate))
                .AfterMap((s, d) => d.UpdateLocations(s.AdditionalLocationsIds));
            CreateMap<OpportunityUpdateDto, Opportunity>()
                .AfterMap((s, d) => d.UpdateLocations(s.AdditionalLocationsIds));
        }

        private void RoleMapping()
        {
            CreateMap<IdentityRole<int>, RoleReadDTO>()
                .ForMember(
                    e => e.Id,
                    m => m.MapFrom(o => o.Name)
                );
        }

        private void PositionSlotMapping()
        {
            CreateMap<PositionSlot, PositionSlotReadDto>()
                .ForMember(
                    e => e.AdditionalLocationsIds,
                    m => m.MapFrom(o => o.AdditionalPositionSlotLocations.Select(l => l.LocationId))
                );
            CreateMap<PositionSlot, PositionSlotDisplayDto>()
                .ForMember(
                    e => e.LocationId,
                    m => m.MapFrom(o => o.Location != null ? o.Location.Description : string.Empty)
                );
            CreateMap<PositionSlotCreateDto, PositionSlot>()
                .ConstructUsing(d => new PositionSlot(d.PositionId, d.SeniorityId, d.LocationId))
                .AfterMap((s, d) => d.UpdateLocations(s.AdditionalLocationsIds));
            CreateMap<PositionSlotUpdateDto, PositionSlot>()
                .AfterMap((s, d) => d.UpdateLocations(s.AdditionalLocationsIds));
        }
    }
}
