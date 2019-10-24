using EY.TalentSurfer.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EY.TalentSurfer.Support.Persistence.Sql.InitialDataLoad
{
    class PositionDataSeed : IEntityTypeConfiguration<Position>
    {
        private readonly IDateTimeProvider _dateTimeProvider;

        public PositionDataSeed(IDateTimeProvider dateTimeProvider)
        {
            _dateTimeProvider = dateTimeProvider;
        }

        public void Configure(EntityTypeBuilder<Position> builder)
        {
            builder.HasData(
                new Position { Id = 1, Description = "** Not Needed **", CreatedOn = _dateTimeProvider.UtcNow, CreatedBy = "Initial Data Load" },
                new Position { Id = 2, Description = ".Net Developer", CreatedOn = _dateTimeProvider.UtcNow, CreatedBy = "Initial Data Load" },
                new Position { Id = 3, Description = "BI Developer", CreatedOn = _dateTimeProvider.UtcNow, CreatedBy = "Initial Data Load" },
                new Position { Id = 4, Description = "BPM Developer", CreatedOn = _dateTimeProvider.UtcNow, CreatedBy = "Initial Data Load" },
                new Position { Id = 5, Description = "Business Analyst", CreatedOn = _dateTimeProvider.UtcNow, CreatedBy = "Initial Data Load" },
                new Position { Id = 6, Description = "Business Intelligence", CreatedOn = _dateTimeProvider.UtcNow, CreatedBy = "Initial Data Load" },
                new Position { Id = 7, Description = "Data Architect", CreatedOn = _dateTimeProvider.UtcNow, CreatedBy = "Initial Data Load" },
                new Position { Id = 8, Description = "Data Scientist", CreatedOn = _dateTimeProvider.UtcNow, CreatedBy = "Initial Data Load" },
                new Position { Id = 9, Description = "DBA", CreatedOn = _dateTimeProvider.UtcNow, CreatedBy = "Initial Data Load" },
                new Position { Id = 10, Description = "DevOps/Cloud Engineer", CreatedOn = _dateTimeProvider.UtcNow, CreatedBy = "Initial Data Load" },
                new Position { Id = 11, Description = "Java Developer", CreatedOn = _dateTimeProvider.UtcNow, CreatedBy = "Initial Data Load" },
                new Position { Id = 12, Description = "Mobile Developer", CreatedOn = _dateTimeProvider.UtcNow, CreatedBy = "Initial Data Load" },
                new Position { Id = 13, Description = "Performance Test Engineer", CreatedOn = _dateTimeProvider.UtcNow, CreatedBy = "Initial Data Load" },
                new Position { Id = 14, Description = "Project Manager", CreatedOn = _dateTimeProvider.UtcNow, CreatedBy = "Initial Data Load" },
                new Position { Id = 15, Description = "Python Developer", CreatedOn = _dateTimeProvider.UtcNow, CreatedBy = "Initial Data Load" },
                new Position { Id = 16, Description = "QC Analyst", CreatedOn = _dateTimeProvider.UtcNow, CreatedBy = "Initial Data Load" },
                new Position { Id = 17, Description = "Salesforce Developer", CreatedOn = _dateTimeProvider.UtcNow, CreatedBy = "Initial Data Load" },
                new Position { Id = 18, Description = "Scrum Master", CreatedOn = _dateTimeProvider.UtcNow, CreatedBy = "Initial Data Load" },
                new Position { Id = 19, Description = "Service Now Developer", CreatedOn = _dateTimeProvider.UtcNow, CreatedBy = "Initial Data Load" },
                new Position { Id = 20, Description = "Sharepoint Developer", CreatedOn = _dateTimeProvider.UtcNow, CreatedBy = "Initial Data Load" },
                new Position { Id = 21, Description = "SOA Developer", CreatedOn = _dateTimeProvider.UtcNow, CreatedBy = "Initial Data Load" },
                new Position { Id = 22, Description = "SQL Developer", CreatedOn = _dateTimeProvider.UtcNow, CreatedBy = "Initial Data Load" },
                new Position { Id = 23, Description = "Test Automation Engineer", CreatedOn = _dateTimeProvider.UtcNow, CreatedBy = "Initial Data Load" },
                new Position { Id = 24, Description = "Tech Manager", CreatedOn = _dateTimeProvider.UtcNow, CreatedBy = "Initial Data Load" },
                new Position { Id = 25, Description = "SME", CreatedOn = _dateTimeProvider.UtcNow, CreatedBy = "Initial Data Load" },
                new Position { Id = 26, Description = "User Experience Designer", CreatedOn = _dateTimeProvider.UtcNow, CreatedBy = "Initial Data Load" },
                new Position { Id = 27, Description = "Visual Designer", CreatedOn = _dateTimeProvider.UtcNow, CreatedBy = "Initial Data Load" },
                new Position { Id = 28, Description = "Web UI Developer", CreatedOn = _dateTimeProvider.UtcNow, CreatedBy = "Initial Data Load" }
                );                                                                                                                              
        }
    }
}
