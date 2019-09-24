using EY.TalentSurfer.Domain;
using Microsoft.EntityFrameworkCore;

namespace EY.TalentSurfer.Support.Persistence.Sql
{
    public class TalentSurferContext : DbContext
    {
        public TalentSurferContext(DbContextOptions<TalentSurferContext> options)
            : base(options)
        {
        }

        public DbSet<BusinessUnit> BusinessUnit { get; set; }
        public DbSet<Certainty> Certainty { get; set; }
        public DbSet<Location> Location { get; set; }
        public DbSet<Position> Position { get; set; }
        public DbSet<PositionStatus> PositionStatus { get; set; }
        public DbSet<Seniority> Seniority { get; set; }
        public DbSet<Status> Status { get; set; }
    }
}
