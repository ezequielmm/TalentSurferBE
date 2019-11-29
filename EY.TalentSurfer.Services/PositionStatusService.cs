using AutoMapper;
using EY.TalentSurfer.Domain;
using EY.TalentSurfer.Dto;
using EY.TalentSurfer.Services.Contracts;
using EY.TalentSurfer.Support.Persistence;
using EY.TalentSurfer.Support.Persistence.Sql;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;


namespace EY.TalentSurfer.Services
{
    public class PositionStatusService : BaseService<PositionStatus, PositionStatusCreateDto, PositionStatusReadDto, PositionStatusUpdateDto>, IPositionStatusService
    {
        IRepository<PositionStatus> _positionStatusRepo;
        public PositionStatusService(IRepository<PositionStatus> repository, IMapper mapper) : base(repository, mapper)
        {
            _positionStatusRepo = repository;
        }      
    }
}
