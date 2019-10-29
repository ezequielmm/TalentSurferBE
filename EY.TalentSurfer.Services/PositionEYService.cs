using AutoMapper;
using EY.TalentSurfer.Domain;
using EY.TalentSurfer.Dto;
using EY.TalentSurfer.Services.Contracts;
using EY.TalentSurfer.Support.Persistence;

namespace EY.TalentSurfer.Services
{
    public class PositionEYService : 
        BaseService<PositionEY, PositionEYCreateDto, PositionEYReadDto, PositionEYUpdateDto>, IPositionEYService
    {
        public PositionEYService(IRepository<PositionEY> repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
