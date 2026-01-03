using carrocerias.models;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace carrocerias.Data
{
    public class BudgetProductConfiguration : IEntityTypeConfiguration<BudgetProduct>
    {
        public void Configure(EntityTypeBuilder<BudgetProduct> builder)
        {
            builder.ToTable("BudgetProducts");

            builder.HasOne(bp => bp.Product)
                .WithMany(p => p.BudgetProducts)
                .HasForeignKey(bp => bp.ProductId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(bp => bp.Contact)
                .WithMany(c => c.BudgetProducts)
                .HasForeignKey(bp => bp.ContactId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
