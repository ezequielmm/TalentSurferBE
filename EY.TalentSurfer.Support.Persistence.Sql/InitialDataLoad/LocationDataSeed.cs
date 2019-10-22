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
                new Location { Id = 1, SortOrder = 1, Description = "Anywhere", CreatedOn = _dateTimeProvider.UtcNow, CreatedBy = "Initial Data Load" },
                new Location { Id = 2, SortOrder = 2, Description = "Anywhere LATAM", CreatedOn = _dateTimeProvider.UtcNow, CreatedBy = "Initial Data Load" },
                new Location { Id = 3, SortOrder = 3, Description = "Anywhere INDIA", CreatedOn = _dateTimeProvider.UtcNow, CreatedBy = "Initial Data Load" },
                new Location { Id = 4, SortOrder = 4, Description = "US", CreatedOn = _dateTimeProvider.UtcNow, CreatedBy = "Initial Data Load" },
                new Location { Id = 5, SortOrder = 5, Description = "Anywhere ARG", CreatedOn = _dateTimeProvider.UtcNow, CreatedBy = "Initial Data Load" },
                new Location { Id = 6, SortOrder = 6, Description = "Anywhere CO", CreatedOn = _dateTimeProvider.UtcNow, CreatedBy = "Initial Data Load" },
                new Location { Id = 7, SortOrder = 7, Description = "Pune", CreatedOn = _dateTimeProvider.UtcNow, CreatedBy = "Initial Data Load" },
                new Location { Id = 8, SortOrder = 8, Description = "Bangalore", CreatedOn = _dateTimeProvider.UtcNow, CreatedBy = "Initial Data Load" },
                new Location { Id = 9, SortOrder = 9, Description = "CABA", CreatedOn = _dateTimeProvider.UtcNow, CreatedBy = "Initial Data Load" },
                new Location { Id = 10, SortOrder = 10, Description = "CBA", CreatedOn = _dateTimeProvider.UtcNow, CreatedBy = "Initial Data Load" },
                new Location { Id = 11, SortOrder = 11, Description = "RO", CreatedOn = _dateTimeProvider.UtcNow, CreatedBy = "Initial Data Load" },
                new Location { Id = 12, SortOrder = 12, Description = "MDZ", CreatedOn = _dateTimeProvider.UtcNow, CreatedBy = "Initial Data Load" },
                new Location { Id = 13, SortOrder = 13, Description = "Bogota", CreatedOn = _dateTimeProvider.UtcNow, CreatedBy = "Initial Data Load" },
                new Location { Id = 14, SortOrder = 14, Description = "Medellin", CreatedOn = _dateTimeProvider.UtcNow, CreatedBy = "Initial Data Load" }
                );
        }
    }
}
