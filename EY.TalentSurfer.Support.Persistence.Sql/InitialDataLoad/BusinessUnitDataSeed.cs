using EY.TalentSurfer.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EY.TalentSurfer.Support.Persistence.Sql.InitialDataLoad
{
    class BusinessUnitDataSeed : IEntityTypeConfiguration<BusinessUnit>
    {
        private readonly IDateTimeProvider _dateTimeProvider;

        public BusinessUnitDataSeed(IDateTimeProvider dateTimeProvider)
        {
            _dateTimeProvider = dateTimeProvider;
        }

        public void Configure(EntityTypeBuilder<BusinessUnit> builder)
        {
            builder.HasData(
                new BusinessUnit { Id = 1, SortOrder = 1, Description = "Platform", CreatedOn = _dateTimeProvider.UtcNow, CreatedBy = "Initial Data Load" },
                new BusinessUnit { Id = 2, SortOrder = 2, Description = "ATTG", CreatedOn = _dateTimeProvider.UtcNow, CreatedBy = "Initial Data Load" },
                new BusinessUnit { Id = 3, SortOrder = 3, Description = "GTP", CreatedOn = _dateTimeProvider.UtcNow, CreatedBy = "Initial Data Load" },
                new BusinessUnit { Id = 4, SortOrder = 4, Description = "Business", CreatedOn = _dateTimeProvider.UtcNow, CreatedBy = "Initial Data Load" }
                );
        }
    }
}
