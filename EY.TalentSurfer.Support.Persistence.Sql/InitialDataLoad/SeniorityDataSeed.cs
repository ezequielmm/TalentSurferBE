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
                new Seniority ( 1, "** Not Needed **",  _dateTimeProvider.UtcNow,  "Initial Data Load" ),
                new Seniority ( 2, "Trainee",  _dateTimeProvider.UtcNow,  "Initial Data Load" ),
                new Seniority ( 3, "Junior",  _dateTimeProvider.UtcNow,  "Initial Data Load" ),
                new Seniority ( 4, "Junior Adv",  _dateTimeProvider.UtcNow,  "Initial Data Load" ),
                new Seniority ( 5, "SSr",  _dateTimeProvider.UtcNow,  "Initial Data Load" ),
                new Seniority ( 6, "SSr Adv",  _dateTimeProvider.UtcNow,  "Initial Data Load" ),
                new Seniority ( 7, "Senior",  _dateTimeProvider.UtcNow,  "Initial Data Load" ),
                new Seniority ( 8, "SD / Level 2",  _dateTimeProvider.UtcNow,  "Initial Data Load" ),
                new Seniority ( 9, "Architect / Level 3",  _dateTimeProvider.UtcNow,  "Initial Data Load" ),
                new Seniority ( 10,  "Level 4",  _dateTimeProvider.UtcNow,  "Initial Data Load" ),
                new Seniority ( 12,  "Level 5",  _dateTimeProvider.UtcNow,  "Initial Data Load" )
                );
        }
    }
}
