using carrocerias.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace carrocerias.Data
{
    public class ProductServiceConfiguration : IEntityTypeConfiguration<ProductService>
    {
        public void Configure(EntityTypeBuilder<ProductService> builder)
        {
            builder.ToTable("ProductService");

            builder.HasOne(ps => ps.Product)
                .WithMany(p => p.ProductServices)
                .HasForeignKey(ps => ps.ProductId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(ps => ps.Service)
                .WithMany(s => s.ProductServices)
                .HasForeignKey(ps => ps.ServiceId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
