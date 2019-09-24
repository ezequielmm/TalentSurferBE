using AutoMapper;
using EY.TalentSurfer.Domain;
using EY.TalentSurfer.Services.Contracts;
using EY.TalentSurfer.Support.Persistence;

namespace EY.TalentSurfer.Services
{
    public class StatusService : BaseService<Status>, IStatusService
    {
        public StatusService(IRepository<Status> repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
