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
                new Certainty ( 1, "1. Lost",  "0%",  _dateTimeProvider.UtcNow,  "Initial Data Load" ),
                new Certainty ( 2, "2. Forecast",  "20%",  _dateTimeProvider.UtcNow,  "Initial Data Load" ),
                new Certainty ( 3, "3. Under Discussion",  "40%",  _dateTimeProvider.UtcNow,  "Initial Data Load" ),
                new Certainty ( 4, "4. Proposal Sent",  "60%",  _dateTimeProvider.UtcNow,  "Initial Data Load" ),
                new Certainty ( 5, "5. SOW Sent",  "80%",  _dateTimeProvider.UtcNow,  "Initial Data Load" ),
                new Certainty ( 6, "6. SOW Approved",  "100%",  _dateTimeProvider.UtcNow,  "Initial Data Load" )
                );
        }
    }
}
