namespace carrocerias.models
{
    public class QuoteChangeHistory
    {
        public int Id { get; set; }
        public int QuoteId { get; set; }
        public Quote Quote { get; set; } = null!;
        public string Field { get; set; } = null!;
        public string PrevValue { get; set; } = null!;
        public string NewValue { get; set; } = null!;
        public bool ClientRequest { get; set; } = false;
        public string Reason { get; set; } = null!;
    }
}
