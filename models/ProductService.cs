namespace carrocerias.models
{
    public class ProductService
    {
        public int Id { get; set; }
        public int ServiceId { get; set; }
        public Service Service { get; set; } = null!;
        public int ProductId { get; set; }
        public Product Product { get; set; } = null!;
        public int Quantity { get; set; }
    }
}
