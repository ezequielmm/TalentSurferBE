using EY.TalentSurfer.Dto;
using System.Threading.Tasks;

namespace EY.TalentSurfer.Services.Contracts
{
   public interface IGloberService
    {
       Task <GloberReadDto> GetGloberDetails(string key, int offset, int limit);
    }
}
