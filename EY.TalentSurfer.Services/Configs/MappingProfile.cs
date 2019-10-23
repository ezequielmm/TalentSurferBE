﻿using System;
using System.Linq;
using AutoMapper;
using AutoMapper.EquivalencyExpression;
using EY.TalentSurfer.Domain;
using EY.TalentSurfer.Dto;

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

            OpportunityMapping();
        }

        private void OpportunityMapping()
        {
            CreateMap<Opportunity, OpportunityReadDto>()
                .ForMember(
                    e => e.AdditionalLocationsIds,
                    m => m.MapFrom(o => o.AdditionalLocations.Select(l => l.Id))
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
    }
}
