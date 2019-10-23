using System.Linq;
using EY.TalentSurfer.Domain;
using Microsoft.EntityFrameworkCore;

namespace EY.TalentSurfer.Support.Persistence.Sql
{
    public class OpportunityRepository : EntityRepository<Opportunity>, IOpportunityRepository
    {
        public OpportunityRepository(TalentSurferContext context) : base(context)
        {
        }

        protected override IQueryable<Opportunity> Query =>
            _context.Set<Opportunity>()
                .Include(o => o.AdditionalOpportunityLocations)
                    .ThenInclude(o => o.Location)
                .Include(o => o.Status);
    }
}
