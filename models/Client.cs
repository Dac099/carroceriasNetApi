namespace carrocerias.models
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string email { get; set; } = null!;
        public string phone { get; set; } = null!;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public int? CompanyId { get; set; }
        public Company? Company { get; set; } 
    }
}
