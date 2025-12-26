namespace carrocerias.models
{
    public class BudgetProduct
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; } = null!;
        public int ContactId { get; set; }
        public Contact Contact { get; set; } = null!;
        public float Price { get; set; }
        public DateTime BudgetAt { get; set; }
    }
}
