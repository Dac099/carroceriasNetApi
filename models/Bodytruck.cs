namespace carrocerias.models
{
    public class Bodytruck
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int CategoryId { get; set; }
        public BodytruckCategory Category { get; set; } = null!;
        public string MediaUrl { get; set; } = null!;
        public ICollection<QuoteBodytruck> QuoteBodytrucks { get; set; } = new List<QuoteBodytruck>();
    }
}
