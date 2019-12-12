using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EY.TalentSurfer.Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace EY.TalentSurfer.Support.Persistence.Sql
{
    public class RoleRepository : IRoleRepository
    {
        TalentSurferContext _context;
        public RoleRepository(TalentSurferContext context) 
        {
            _context = context;
        }

        public async Task<IEnumerable<IdentityRole<int>>> ToListAsync()
        {
            return await _context.Roles.ToListAsync();

        }
    }
}
