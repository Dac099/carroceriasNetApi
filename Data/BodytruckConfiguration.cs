using carrocerias.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace carrocerias.Data
{
    public class BodytruckConfiguration : IEntityTypeConfiguration<Bodytruck>
    {
        public void Configure(EntityTypeBuilder<Bodytruck> builder)
        {
            builder.ToTable("Bodytrucks");

            builder.HasOne(b => b.Category)
                .WithMany(c => c.Bodytrucks)
                .HasForeignKey(b => b.CategoryId)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
