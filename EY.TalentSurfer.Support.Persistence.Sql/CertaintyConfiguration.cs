using EY.TalentSurfer.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EY.TalentSurfer.Support.Persistence.Sql
{
    public class CertaintyConfiguration : IEntityTypeConfiguration<Certainty>
    {
        public void Configure(EntityTypeBuilder<Certainty> builder)
        {
            builder
                .HasAlternateKey(b => b.Description);

            builder
                .HasAlternateKey(e => e.Value);

        }
    }
}
