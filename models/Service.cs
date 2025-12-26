namespace carrocerias.models
{
    public class Service
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public ICollection<QuoteService> QuoteServices { get; set; } = new List<QuoteService>();
        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
