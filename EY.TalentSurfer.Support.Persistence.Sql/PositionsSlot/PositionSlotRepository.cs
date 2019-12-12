using EY.TalentSurfer.Domain;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace EY.TalentSurfer.Support.Persistence.Sql.PositionsSlot
{
    public class PositionSlotRepository : EntityRepository<PositionSlot>, IPositionSlotRepository
    {
        public PositionSlotRepository(TalentSurferContext context) : base(context)
        {
        }

        protected override IQueryable<PositionSlot> Query =>
            _context.Set<PositionSlot>()
                .Include(o => o.AdditionalPositionSlotLocations)
                    .ThenInclude(o => o.Location);
                
    }
}
