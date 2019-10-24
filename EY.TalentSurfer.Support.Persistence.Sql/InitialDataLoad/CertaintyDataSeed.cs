using EY.TalentSurfer.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EY.TalentSurfer.Support.Persistence.Sql.InitialDataLoad
{
    class CertaintyDataSeed : IEntityTypeConfiguration<Certainty>
    {
        private readonly IDateTimeProvider _dateTimeProvider;

        public CertaintyDataSeed(IDateTimeProvider dateTimeProvider)
        {
            _dateTimeProvider = dateTimeProvider;
        }

        public void Configure(EntityTypeBuilder<Certainty> builder)
        {
            builder.HasData(
                new Certainty { Id = 1, Description = "1. Lost", Value = "0%", CreatedOn = _dateTimeProvider.UtcNow, CreatedBy = "Initial Data Load" },
                new Certainty { Id = 2, Description = "2. Forecast", Value = "20%", CreatedOn = _dateTimeProvider.UtcNow, CreatedBy = "Initial Data Load" },
                new Certainty { Id = 3, Description = "3. Under Discussion", Value = "40%", CreatedOn = _dateTimeProvider.UtcNow, CreatedBy = "Initial Data Load" },
                new Certainty { Id = 4, Description = "4. Proposal Sent", Value = "60%", CreatedOn = _dateTimeProvider.UtcNow, CreatedBy = "Initial Data Load" },
                new Certainty { Id = 5, Description = "5. SOW Sent", Value = "80%", CreatedOn = _dateTimeProvider.UtcNow, CreatedBy = "Initial Data Load" },
                new Certainty { Id = 6, Description = "6. SOW Approved", Value = "100%", CreatedOn = _dateTimeProvider.UtcNow, CreatedBy = "Initial Data Load" }
                );
        }
    }
}
