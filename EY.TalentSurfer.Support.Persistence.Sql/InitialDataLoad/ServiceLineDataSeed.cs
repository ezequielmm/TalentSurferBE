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
                new ServiceLine { Id = 1, Description = "Platform", CreatedOn = _dateTimeProvider.UtcNow, CreatedBy = "Initial Data Load" },
                new ServiceLine { Id = 2, Description = "ATTG", CreatedOn = _dateTimeProvider.UtcNow, CreatedBy = "Initial Data Load" },
                new ServiceLine { Id = 3, Description = "GTP", CreatedOn = _dateTimeProvider.UtcNow, CreatedBy = "Initial Data Load" },
                new ServiceLine { Id = 4, Description = "Business", CreatedOn = _dateTimeProvider.UtcNow, CreatedBy = "Initial Data Load" }
                );
        }
    }
}
