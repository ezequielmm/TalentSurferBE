using EY.TalentSurfer.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EY.TalentSurfer.Support.Persistence.Sql
{
    internal class OpportunityConfiguration : IEntityTypeConfiguration<Opportunity>
    {
        private IDateTimeProvider _dateTimeProvider;

        public OpportunityConfiguration(IDateTimeProvider dateTimeProvider)
        {
            _dateTimeProvider = dateTimeProvider;
        }

        public void Configure(EntityTypeBuilder<Opportunity> builder)
        {
            builder
                .HasMany(e => e.AdditionalOpportunityLocations)
                .WithOne(e => e.Opportunity)
                .HasForeignKey(o => o.OpportunityId);

            builder
                .Metadata
                .FindNavigation(nameof(Opportunity.AdditionalOpportunityLocations))
                .SetPropertyAccessMode(PropertyAccessMode.Field);

            builder
                .Ignore(e => e.AdditionalLocations);

            builder.HasOne(e => e.Certainty)
                .WithMany()
                .HasForeignKey(e => e.CertaintyId);

            builder.HasOne(e => e.Map)
                .WithMany()
                .HasForeignKey(e => e.MapId);

            builder.HasOne(e => e.PrimaryLocation)
                .WithMany()
                .HasForeignKey(e => e.PrimaryLocationId);

            builder.HasOne(e => e.ServiceLine)
                .WithMany()
                .HasForeignKey(e => e.ServiceLineId);

            builder.HasOne(e => e.Status)
                .WithMany()
                .HasForeignKey(e => e.StatusId);
        }
    }
}