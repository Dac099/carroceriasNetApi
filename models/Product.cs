namespace carrocerias.models
{
    public class Product
    {
        public int Id { get; set; }
        public string SupplierCode { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; }
        public ICollection<Service> Services { get; set; } = new List<Service>();
        public ICollection<BudgetProduct> BudgetProducts { get; set; } = new List<BudgetProduct>();
    }
}
