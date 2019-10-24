using EY.TalentSurfer.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EY.TalentSurfer.Support.Persistence.Sql.InitialDataLoad
{
    class StatusDataSeed : IEntityTypeConfiguration<Status>
    {
        private readonly IDateTimeProvider _dateTimeProvider;

        public StatusDataSeed(IDateTimeProvider dateTimeProvider)
        {
            _dateTimeProvider = dateTimeProvider;
        }

        public void Configure(EntityTypeBuilder<Status> builder)
        {
            builder.HasData(
                new Status { Id = 1, Description = "1. Wating for Feedback", CreatedOn = _dateTimeProvider.UtcNow, CreatedBy = "Initial Data Load" },
                new Status { Id = 2, Description = "2. On Hold", CreatedOn = _dateTimeProvider.UtcNow, CreatedBy = "Initial Data Load" },
                new Status { Id = 3, Description = "3. Lost", CreatedOn = _dateTimeProvider.UtcNow, CreatedBy = "Initial Data Load" },
                new Status { Id = 4, Description = "4. Won", CreatedOn = _dateTimeProvider.UtcNow, CreatedBy = "Initial Data Load" }
                );
        }
    }
}
