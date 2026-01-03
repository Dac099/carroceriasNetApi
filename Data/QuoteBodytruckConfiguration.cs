using carrocerias.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace carrocerias.Data
{
    public class QuoteBodytruckConfiguration : IEntityTypeConfiguration<QuoteBodytruck>
    {
        public void Configure(EntityTypeBuilder<QuoteBodytruck> builder)
        {
            builder.ToTable("QuoteBodytrucks");

            builder.HasOne(qb => qb.Bodytruck)
                .WithMany(b => b.QuoteBodytrucks)
                .HasForeignKey(qb => qb.BodytruckId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(qb => qb.Quote)
                .WithMany(q => q.QuoteBodytrucks)
                .HasForeignKey(qb => qb.QuoteId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
