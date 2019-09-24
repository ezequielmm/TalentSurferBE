using AutoMapper;
using EY.TalentSurfer.Domain;
using EY.TalentSurfer.Services.Contracts;
using EY.TalentSurfer.Support.Persistence;

namespace EY.TalentSurfer.Services
{
    public class PositionStatusService : BaseService<PositionStatus>, IPositionStatusService
    {
        public PositionStatusService(IRepository<PositionStatus> repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
