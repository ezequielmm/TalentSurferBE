using EY.TalentSurfer.Domain;
using EY.TalentSurfer.Support.Persistence.Sql.InitialDataLoad;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace EY.TalentSurfer.Support.Persistence.Sql
{
    public class TalentSurferContext : IdentityDbContext<User, IdentityRole<int>, int>
    {
        private readonly IUserProvider _userProvider;
        private readonly IDateTimeProvider _dateTimeProvider;

        public TalentSurferContext(DbContextOptions<TalentSurferContext> options, IUserProvider userProvider, IDateTimeProvider dateTimeProvider)
            : base(options)
        {
            _userProvider = userProvider;
            _dateTimeProvider = dateTimeProvider;
        }

        public DbSet<ServiceLine> ServiceLine { get; set; }
        public DbSet<Certainty> Certainty { get; set; }
        public DbSet<Location> Location { get; set; }
        public DbSet<Position> Position { get; set; }
        public DbSet<PositionStatus> PositionStatus { get; set; }
        public DbSet<Seniority> Seniority { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<Opportunity> Opportunity { get; set; }
        public DbSet<OpportunityLocation> OpportunityLocation { get; set; }
        public DbSet<PositionSlot> PositionSlot { get; set; }
        public DbSet<PositionSlotLocation> PositionSlotLocation { get; set; }
        public DbSet<Project> Project { get; set; }
        public DbSet<PositionEY> PositionEY { get; set; }
        public DbSet<Sow> Sow { get; set; }
        public DbSet<RefreshToken> RefreshToken { get; set; }
      

        public async override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            AuditEntries();
            return await base.SaveChangesAsync(cancellationToken);
        }

        public async override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default(CancellationToken))
        {
            AuditEntries();
            return await base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }

        private void AuditEntries()
        {
            foreach (var entityEntry in ChangeTracker.Entries().Where(e => e.Entity is IAuditableEntity).ToList())
            {
                switch (entityEntry.State)
                {
                    case EntityState.Modified:
                        Entry(entityEntry.Entity as IAuditableEntity).Property(e => e.ModifiedBy).CurrentValue = _userProvider.Email ?? _userProvider.AppId;
                        Entry(entityEntry.Entity as IAuditableEntity).Property(e => e.ModifiedOn).CurrentValue = _dateTimeProvider.Now;
                        Entry(entityEntry.Entity as IAuditableEntity).Property(e => e.CreatedBy).IsModified = false;
                        Entry(entityEntry.Entity as IAuditableEntity).Property(e => e.CreatedOn).IsModified = false;
                        break;
                    case EntityState.Added:
                        Entry(entityEntry.Entity as IAuditableEntity).Property(e => e.CreatedBy).CurrentValue = _userProvider.Email ?? _userProvider.AppId;
                        Entry(entityEntry.Entity as IAuditableEntity).Property(e => e.CreatedOn).CurrentValue = _dateTimeProvider.Now;
                        break;
                }
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new LocationDataSeed(_dateTimeProvider));
            modelBuilder.ApplyConfiguration(new PositionDataSeed(_dateTimeProvider));
            modelBuilder.ApplyConfiguration(new StatusDataSeed(_dateTimeProvider));
            modelBuilder.ApplyConfiguration(new ServiceLineDataSeed(_dateTimeProvider));
            modelBuilder.ApplyConfiguration(new SeniorityDataSeed(_dateTimeProvider));
            modelBuilder.ApplyConfiguration(new PositionStatusDataSeed(_dateTimeProvider));
            modelBuilder.ApplyConfiguration(new CertaintyDataSeed(_dateTimeProvider));
            modelBuilder.Entity<OpportunityLocation>()
                .HasKey(e => new { e.OpportunityId, e.LocationId });
            modelBuilder.ApplyConfiguration(new OpportunityConfiguration(_dateTimeProvider));
            modelBuilder.Entity<PositionSlotLocation>()
               .HasKey(e => new { e.PositionSlotId, e.LocationId });
            modelBuilder.ApplyConfiguration(new PositionSlotConfiguration(_dateTimeProvider));

        }
    }
}
