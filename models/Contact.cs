namespace carrocerias.models
{
    public class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string Position { get; set; } = null!;
        public int CompanyId { get; set; }
        public Company Company { get; set; } = null!;
        public ICollection<BudgetProduct> BudgetProducts { get; set; } = new List<BudgetProduct>();
    }
}
