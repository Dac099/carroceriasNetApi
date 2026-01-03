using carrocerias.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace carrocerias.Data
{
    public class QuoteServiceConfiguration : IEntityTypeConfiguration<QuoteService>
    {
        public void Configure(EntityTypeBuilder<QuoteService> builder)
        {
            builder.ToTable("QuoteServices");

            builder.HasOne(qs => qs.Quote)
                .WithMany(q => q.QuoteServices)
                .HasForeignKey(qs => qs.QuoteId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(qs => qs.Service)
                .WithMany(s => s.QuoteServices)
                .HasForeignKey(qs => qs.ServiceId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
