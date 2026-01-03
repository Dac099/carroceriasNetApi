namespace carrocerias.models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; }
        public ICollection<ProductService> ProductServices { get; set; } = new List<ProductService>();
        public ICollection<BudgetProduct> BudgetProducts { get; set; } = new List<BudgetProduct>();
    }
}
