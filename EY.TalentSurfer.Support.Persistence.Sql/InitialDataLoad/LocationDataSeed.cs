using EY.TalentSurfer.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EY.TalentSurfer.Support.Persistence.Sql.InitialDataLoad
{
    class LocationDataSeed : IEntityTypeConfiguration<Location>
    {
        private readonly IDateTimeProvider _dateTimeProvider;

        public LocationDataSeed(IDateTimeProvider dateTimeProvider)
        {
            _dateTimeProvider = dateTimeProvider;
        }

        public void Configure(EntityTypeBuilder<Location> builder)
        {
            builder.HasData(
                new Location(1, "Anywhere", _dateTimeProvider.UtcNow, "Initial Data Load"),
                new Location(2, "Anywhere LATAM", _dateTimeProvider.UtcNow, "Initial Data Load"),
                new Location(3, "Anywhere INDIA", _dateTimeProvider.UtcNow, "Initial Data Load"),
                new Location(4, "US", _dateTimeProvider.UtcNow, "Initial Data Load"),
                new Location(5, "Anywhere ARG", _dateTimeProvider.UtcNow, "Initial Data Load"),
                new Location(6, "Anywhere CO", _dateTimeProvider.UtcNow, "Initial Data Load"),
                new Location(7, "Pune", _dateTimeProvider.UtcNow, "Initial Data Load"),
                new Location(8, "Bangalore", _dateTimeProvider.UtcNow, "Initial Data Load"),
                new Location(9, "CABA", _dateTimeProvider.UtcNow, "Initial Data Load"),
                new Location(10, "CBA", _dateTimeProvider.UtcNow, "Initial Data Load"),
                new Location(11, "RO", _dateTimeProvider.UtcNow, "Initial Data Load"),
                new Location(12, "MDZ", _dateTimeProvider.UtcNow, "Initial Data Load"),
                new Location(13, "Bogota", _dateTimeProvider.UtcNow, "Initial Data Load"),
                new Location(14, "Medellin", _dateTimeProvider.UtcNow, "Initial Data Load")
                );
        }
    }
}
