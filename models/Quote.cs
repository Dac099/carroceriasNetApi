namespace carrocerias.models
{
    public class Quote
    {
        public int Id { get; set; }
        public string Code { get; set; } = null!;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; }      
        public ICollection<QuoteService> QuoteServices { get; set; } = new List<QuoteService>();
        public ICollection<QuoteBodytruck> QuoteBodytrucks { get; set; } = new List<QuoteBodytruck>();
        public ICollection<QuoteChangeHistory> QuoteChangeHistories { get; set; } = new List<QuoteChangeHistory>();
    }
}
