using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using EY.TalentSurfer.Domain;
using Microsoft.EntityFrameworkCore;

namespace EY.TalentSurfer.Support.Persistence.Sql
{
    public class TalentSurferContext : DbContext
    {
        private readonly IUserProvider _userProvider;
        private readonly IDateTimeProvider _dateTimeProvider;

        public TalentSurferContext(DbContextOptions<TalentSurferContext> options, IUserProvider userProvider, IDateTimeProvider dateTimeProvider)
            : base(options)
        {
            _userProvider = userProvider;
            _dateTimeProvider = dateTimeProvider;
        }

        public DbSet<BusinessUnit> BusinessUnit { get; set; }
        public DbSet<Certainty> Certainty { get; set; }
        public DbSet<Location> Location { get; set; }
        public DbSet<Position> Position { get; set; }
        public DbSet<PositionStatus> PositionStatus { get; set; }
        public DbSet<Seniority> Seniority { get; set; }
        public DbSet<Status> Status { get; set; }

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
    }
}
