using EY.TalentSurfer.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EY.TalentSurfer.Support.Persistence.Sql.InitialDataLoad
{
    class PositionStatusDataSeed : IEntityTypeConfiguration<PositionStatus>
    {
        private readonly IDateTimeProvider _dateTimeProvider;

        public PositionStatusDataSeed(IDateTimeProvider dateTimeProvider)
        {
            _dateTimeProvider = dateTimeProvider;
        }

        public void Configure(EntityTypeBuilder<PositionStatus> builder)
        {
            builder.HasData(
                new PositionStatus(1, "** Not Needed **", _dateTimeProvider.UtcNow, "Initial Data Load"),
                new PositionStatus(2, "1. No Candidates", _dateTimeProvider.UtcNow, "Initial Data Load"),
                new PositionStatus(3, "2. Internal FIT", _dateTimeProvider.UtcNow, "Initial Data Load"),
                new PositionStatus(4, "3. Canfirmed (NOW)", _dateTimeProvider.UtcNow, "Initial Data Load"),
                new PositionStatus(5, "4. Confirmed (Future)", _dateTimeProvider.UtcNow, "Initial Data Load")
                );
        }
    }
}
