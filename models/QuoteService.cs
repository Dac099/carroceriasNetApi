namespace carrocerias.models
{
    public class QuoteService
    {
        public int Id { get; set; }
        public int QuoteId { get; set; }
        public int ServiceId { get; set; }
        public Quote Quote { get; set; } = null!;
        public Service Service { get; set; } = null!;
        public float Price { get; set; }
        public string Notes { get; set; } = null!;
    }
}
