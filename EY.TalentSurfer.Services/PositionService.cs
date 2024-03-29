﻿using AutoMapper;
using EY.TalentSurfer.Domain;
using EY.TalentSurfer.Dto;
using EY.TalentSurfer.Services.Contracts;
using EY.TalentSurfer.Support.Persistence;

namespace EY.TalentSurfer.Services
{
    public class PositionService : 
        BaseService<Position, PositionCreateDto, PositionReadDto, PositionUpdateDto>, IPositionService
    {
        public PositionService(IRepository<Position> repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
