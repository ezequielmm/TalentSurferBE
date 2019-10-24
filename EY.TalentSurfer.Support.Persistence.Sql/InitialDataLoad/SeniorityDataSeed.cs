using EY.TalentSurfer.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EY.TalentSurfer.Support.Persistence.Sql.InitialDataLoad
{
    class SeniorityDataSeed : IEntityTypeConfiguration<Seniority>
    {
        private readonly IDateTimeProvider _dateTimeProvider;

        public SeniorityDataSeed(IDateTimeProvider dateTimeProvider)
        {
            _dateTimeProvider = dateTimeProvider;
        }

        public void Configure(EntityTypeBuilder<Seniority> builder)
        {
            builder.HasData(
                new Seniority { Id = 1, Description = "** Not Needed **", CreatedOn = _dateTimeProvider.UtcNow, CreatedBy = "Initial Data Load" },
                new Seniority { Id = 2, Description = "Trainee", CreatedOn = _dateTimeProvider.UtcNow, CreatedBy = "Initial Data Load" },
                new Seniority { Id = 3, Description = "Junior", CreatedOn = _dateTimeProvider.UtcNow, CreatedBy = "Initial Data Load" },
                new Seniority { Id = 4, Description = "Junior Adv", CreatedOn = _dateTimeProvider.UtcNow, CreatedBy = "Initial Data Load" },
                new Seniority { Id = 5, Description = "SSr", CreatedOn = _dateTimeProvider.UtcNow, CreatedBy = "Initial Data Load" },
                new Seniority { Id = 6, Description = "SSr Adv", CreatedOn = _dateTimeProvider.UtcNow, CreatedBy = "Initial Data Load" },
                new Seniority { Id = 7, Description = "Senior", CreatedOn = _dateTimeProvider.UtcNow, CreatedBy = "Initial Data Load" },
                new Seniority { Id = 8, Description = "SD / Level 2", CreatedOn = _dateTimeProvider.UtcNow, CreatedBy = "Initial Data Load" },
                new Seniority { Id = 9, Description = "Architect / Level 3", CreatedOn = _dateTimeProvider.UtcNow, CreatedBy = "Initial Data Load" },
                new Seniority { Id = 10, Description = "Level 4", CreatedOn = _dateTimeProvider.UtcNow, CreatedBy = "Initial Data Load" },
                new Seniority { Id = 12, Description = "Level 5", CreatedOn = _dateTimeProvider.UtcNow, CreatedBy = "Initial Data Load" }
                );
        }
    }
}
