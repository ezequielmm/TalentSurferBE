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
                new Position(1, "** Not Needed **", _dateTimeProvider.UtcNow, "Initial Data Load"),
                new Position(2, ".Net Developer", _dateTimeProvider.UtcNow, "Initial Data Load"),
                new Position(3, "BI Developer", _dateTimeProvider.UtcNow, "Initial Data Load"),
                new Position(4, "BPM Developer", _dateTimeProvider.UtcNow, "Initial Data Load"),
                new Position(5, "Business Analyst", _dateTimeProvider.UtcNow, "Initial Data Load"),
                new Position(6, "Business Intelligence", _dateTimeProvider.UtcNow, "Initial Data Load"),
                new Position(7, "Data Architect", _dateTimeProvider.UtcNow, "Initial Data Load"),
                new Position(8, "Data Scientist", _dateTimeProvider.UtcNow, "Initial Data Load"),
                new Position(9, "DBA", _dateTimeProvider.UtcNow, "Initial Data Load"),
                new Position(10, "DevOps/Cloud Engineer", _dateTimeProvider.UtcNow, "Initial Data Load"),
                new Position(11, "Java Developer", _dateTimeProvider.UtcNow, "Initial Data Load"),
                new Position(12, "Mobile Developer", _dateTimeProvider.UtcNow, "Initial Data Load"),
                new Position(13, "Performance Test Engineer", _dateTimeProvider.UtcNow, "Initial Data Load"),
                new Position(14, "Project Manager", _dateTimeProvider.UtcNow, "Initial Data Load"),
                new Position(15, "Python Developer", _dateTimeProvider.UtcNow, "Initial Data Load"),
                new Position(16, "QC Analyst", _dateTimeProvider.UtcNow, "Initial Data Load"),
                new Position(17, "Salesforce Developer", _dateTimeProvider.UtcNow, "Initial Data Load"),
                new Position(18, "Scrum Master", _dateTimeProvider.UtcNow, "Initial Data Load"),
                new Position(19, "Service Now Developer", _dateTimeProvider.UtcNow, "Initial Data Load"),
                new Position(20, "Sharepoint Developer", _dateTimeProvider.UtcNow, "Initial Data Load"),
                new Position(21, "SOA Developer", _dateTimeProvider.UtcNow, "Initial Data Load"),
                new Position(22, "SQL Developer", _dateTimeProvider.UtcNow, "Initial Data Load"),
                new Position(23, "Test Automation Engineer", _dateTimeProvider.UtcNow, "Initial Data Load"),
                new Position(24, "Tech Manager", _dateTimeProvider.UtcNow, "Initial Data Load"),
                new Position(25, "SME", _dateTimeProvider.UtcNow, "Initial Data Load"),
                new Position(26, "User Experience Designer", _dateTimeProvider.UtcNow, "Initial Data Load"),
                new Position(27, "Visual Designer", _dateTimeProvider.UtcNow, "Initial Data Load"),
                new Position(28, "Web UI Developer", _dateTimeProvider.UtcNow, "Initial Data Load")
                );
        }
    }
}
