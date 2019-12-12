using EY.TalentSurfer.Domain;
using EY.TalentSurfer.Dto;
using EY.TalentSurfer.Dto.Roles;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EY.TalentSurfer.Services.Contracts
{
    public interface IRoleService
    {
        Task<IEnumerable<RoleReadDTO>> GetAllAsync();
    }
}