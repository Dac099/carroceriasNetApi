namespace carrocerias.models
{
    public class QuoteBodytruck
    {
        public int Id { get; set; }
        public int BodytruckId { get; set; }
        public Bodytruck Bodytruck { get; set; } = null!;
        public int QuoteId { get; set; }
        public Quote Quote { get; set; } = null!;
        public float Width { get; set; }
        public float Height { get; set; }
        public float Lenght { get; set; }
        public string Notes { get; set; } = null!;
        public float Price { get; set; }
    }
}
