using EY.TalentSurfer.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EY.TalentSurfer.Support.Persistence.Sql.InitialDataLoad
{
    class ServiceLineDataSeed : IEntityTypeConfiguration<ServiceLine>
    {
        private readonly IDateTimeProvider _dateTimeProvider;

        public ServiceLineDataSeed(IDateTimeProvider dateTimeProvider)
        {
            _dateTimeProvider = dateTimeProvider;
        }

        public void Configure(EntityTypeBuilder<ServiceLine> builder)
        {
            builder.HasData(
                new ServiceLine(1, "Platform", _dateTimeProvider.UtcNow, "Initial Data Load"),
                new ServiceLine(2, "ATTG", _dateTimeProvider.UtcNow, "Initial Data Load"),
                new ServiceLine(3, "GTP", _dateTimeProvider.UtcNow, "Initial Data Load"),
                new ServiceLine(4, "Business", _dateTimeProvider.UtcNow, "Initial Data Load")
                );
        }
    }
}
