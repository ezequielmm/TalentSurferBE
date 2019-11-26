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
                new Status(1, "Wating for Feedback", _dateTimeProvider.UtcNow, "Initial Data Load"),
                new Status(2, "On Hold", _dateTimeProvider.UtcNow, "Initial Data Load"),
                new Status(3, "Lost", _dateTimeProvider.UtcNow, "Initial Data Load"),
                new Status(4, "Won", _dateTimeProvider.UtcNow, "Initial Data Load")
                );
        }
    }
}
