using EY.TalentSurfer.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace EY.TalentSurfer.Support.Persistence.Sql
{
   public class PositionSlotConfiguration : IEntityTypeConfiguration<PositionSlot>
    {
        private IDateTimeProvider _dateTimeProvider;

        public PositionSlotConfiguration(IDateTimeProvider dateTimeProvider)
        {
            _dateTimeProvider = dateTimeProvider;
        }

        public void Configure(EntityTypeBuilder<PositionSlot> builder)
        {
            builder
                 .HasMany(e => e.AdditionalPositionSlotLocations)
                 .WithOne(e => e.PositionSlot)
                 .HasForeignKey(o => o.PositionSlotId).IsRequired();

            builder
                .Metadata
                .FindNavigation(nameof(PositionSlot.AdditionalPositionSlotLocations))
                .SetPropertyAccessMode(PropertyAccessMode.Field);

            builder
                .Ignore(e => e.AdditionalLocations);

            builder.HasOne(e => e.Position)
                .WithMany()
                .HasForeignKey(e => e.PositionId);

            builder.HasOne(e => e.Seniority)
                .WithMany()
                .HasForeignKey(e => e.SeniorityId);

            builder.HasOne(e => e.Location)
                .WithMany()
                .HasForeignKey(e => e.LocationId);

            builder.HasOne(e => e.Location)
                .WithMany()
                .HasForeignKey(e => e.LocationId);
            builder.HasOne(e => e.PositionStatus)
               .WithMany()
               .HasForeignKey(e => e.PostionStatusId);
            builder.HasOne(e => e.CandidateSeniority)
              .WithMany()
              .HasForeignKey(e => e.CandidateSeniorityId);
            builder.HasOne(e => e.CandidateLocation)
          .WithMany()
          .HasForeignKey(e => e.CandidateLocationId);

        }
    }
}
