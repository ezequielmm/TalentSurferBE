using EY.TalentSurfer.Domain;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EY.TalentSurfer.Support.Persistence.Sql
{
    public interface IRoleRepository 
    {
        Task<IEnumerable<IdentityRole<int>>> ToListAsync();
    }
}
