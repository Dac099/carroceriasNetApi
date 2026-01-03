using carrocerias.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace carrocerias.Data
{
    public class QuoteChangeHistoryConfiguration : IEntityTypeConfiguration<QuoteChangeHistory>
    {
        public void Configure(EntityTypeBuilder<QuoteChangeHistory> builder)
        {
            builder.ToTable("QuoteChangeHistory");

            builder.HasOne(qch => qch.Quote)
                .WithMany(q => q.QuoteChangeHistories)
                .HasForeignKey(qch => qch.QuoteId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
