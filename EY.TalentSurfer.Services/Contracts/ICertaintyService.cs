using System.Threading.Tasks;
using EY.TalentSurfer.Domain;
using EY.TalentSurfer.Dto;

namespace EY.TalentSurfer.Services.Contracts
{
    public interface ICertaintyService : IBaseService<Certainty, CertaintyCreateDto, CertaintyReadDto, CertaintyUpdateDto>
    {

    }
}