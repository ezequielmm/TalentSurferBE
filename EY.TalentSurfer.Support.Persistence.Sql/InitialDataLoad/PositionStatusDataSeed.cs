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
                new PositionStatus { Id = 1, Description = "** Not Needed **", CreatedOn = _dateTimeProvider.UtcNow, CreatedBy = "Initial Data Load" },
                new PositionStatus { Id = 2, Description = "1. No Candidates", CreatedOn = _dateTimeProvider.UtcNow, CreatedBy = "Initial Data Load" },
                new PositionStatus { Id = 3, Description = "2. Internal FIT", CreatedOn = _dateTimeProvider.UtcNow, CreatedBy = "Initial Data Load" },
                new PositionStatus { Id = 4, Description = "3. Canfirmed (NOW)", CreatedOn = _dateTimeProvider.UtcNow, CreatedBy = "Initial Data Load" },
                new PositionStatus { Id = 5, Description = "4. Confirmed (Future)", CreatedOn = _dateTimeProvider.UtcNow, CreatedBy = "Initial Data Load" }
                );
        }
    }
}
