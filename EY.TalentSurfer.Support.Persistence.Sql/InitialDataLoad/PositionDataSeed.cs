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
                new Position { Id = 1, SortOrder = 1, Description = "** Not Needed **", CreatedOn = _dateTimeProvider.UtcNow, CreatedBy = "Initial Data Load" },
                new Position { Id = 2, SortOrder = 2, Description = ".Net Developer", CreatedOn = _dateTimeProvider.UtcNow, CreatedBy = "Initial Data Load" },
                new Position { Id = 3, SortOrder = 3, Description = "BI Developer", CreatedOn = _dateTimeProvider.UtcNow, CreatedBy = "Initial Data Load" },
                new Position { Id = 4, SortOrder = 4, Description = "BPM Developer", CreatedOn = _dateTimeProvider.UtcNow, CreatedBy = "Initial Data Load" },
                new Position { Id = 5, SortOrder = 5, Description = "Business Analyst", CreatedOn = _dateTimeProvider.UtcNow, CreatedBy = "Initial Data Load" },
                new Position { Id = 6, SortOrder = 6, Description = "Business Intelligence", CreatedOn = _dateTimeProvider.UtcNow, CreatedBy = "Initial Data Load" },
                new Position { Id = 7, SortOrder = 7, Description = "Data Architect", CreatedOn = _dateTimeProvider.UtcNow, CreatedBy = "Initial Data Load" },
                new Position { Id = 8, SortOrder = 8, Description = "Data Scientist", CreatedOn = _dateTimeProvider.UtcNow, CreatedBy = "Initial Data Load" },
                new Position { Id = 9, SortOrder = 9, Description = "DBA", CreatedOn = _dateTimeProvider.UtcNow, CreatedBy = "Initial Data Load" },
                new Position { Id = 10, SortOrder = 10, Description = "DevOps/Cloud Engineer", CreatedOn = _dateTimeProvider.UtcNow, CreatedBy = "Initial Data Load" },
                new Position { Id = 11, SortOrder = 11, Description = "Java Developer", CreatedOn = _dateTimeProvider.UtcNow, CreatedBy = "Initial Data Load" },
                new Position { Id = 12, SortOrder = 12, Description = "Mobile Developer", CreatedOn = _dateTimeProvider.UtcNow, CreatedBy = "Initial Data Load" },
                new Position { Id = 13, SortOrder = 13, Description = "Performance Test Engineer", CreatedOn = _dateTimeProvider.UtcNow, CreatedBy = "Initial Data Load" },
                new Position { Id = 14, SortOrder = 14, Description = "Project Manager", CreatedOn = _dateTimeProvider.UtcNow, CreatedBy = "Initial Data Load" },
                new Position { Id = 15, SortOrder = 15, Description = "Python Developer", CreatedOn = _dateTimeProvider.UtcNow, CreatedBy = "Initial Data Load" },
                new Position { Id = 16, SortOrder = 16, Description = "QC Analyst", CreatedOn = _dateTimeProvider.UtcNow, CreatedBy = "Initial Data Load" },
                new Position { Id = 17, SortOrder = 17, Description = "Salesforce Developer", CreatedOn = _dateTimeProvider.UtcNow, CreatedBy = "Initial Data Load" },
                new Position { Id = 18, SortOrder = 18, Description = "Scrum Master", CreatedOn = _dateTimeProvider.UtcNow, CreatedBy = "Initial Data Load" },
                new Position { Id = 19, SortOrder = 19, Description = "Service Now Developer", CreatedOn = _dateTimeProvider.UtcNow, CreatedBy = "Initial Data Load" },
                new Position { Id = 20, SortOrder = 20, Description = "Sharepoint Developer", CreatedOn = _dateTimeProvider.UtcNow, CreatedBy = "Initial Data Load" },
                new Position { Id = 21, SortOrder = 21, Description = "SOA Developer", CreatedOn = _dateTimeProvider.UtcNow, CreatedBy = "Initial Data Load" },
                new Position { Id = 22, SortOrder = 22, Description = "SQL Developer", CreatedOn = _dateTimeProvider.UtcNow, CreatedBy = "Initial Data Load" },
                new Position { Id = 23, SortOrder = 23, Description = "Test Automation Engineer", CreatedOn = _dateTimeProvider.UtcNow, CreatedBy = "Initial Data Load" },
                new Position { Id = 24, SortOrder = 24, Description = "Tech Manager", CreatedOn = _dateTimeProvider.UtcNow, CreatedBy = "Initial Data Load" },
                new Position { Id = 25, SortOrder = 25, Description = "SME", CreatedOn = _dateTimeProvider.UtcNow, CreatedBy = "Initial Data Load" },
                new Position { Id = 26, SortOrder = 26, Description = "User Experience Designer", CreatedOn = _dateTimeProvider.UtcNow, CreatedBy = "Initial Data Load" },
                new Position { Id = 27, SortOrder = 27, Description = "Visual Designer", CreatedOn = _dateTimeProvider.UtcNow, CreatedBy = "Initial Data Load" },
                new Position { Id = 28, SortOrder = 28, Description = "Web UI Developer", CreatedOn = _dateTimeProvider.UtcNow, CreatedBy = "Initial Data Load" }
                );                                                                                                                              
        }
    }
}
