namespace carrocerias.models
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Address { get; set; } = null!;
        public ICollection<Client> Clients { get; set; } = new List<Client>();
        public ICollection<Contact> Contacts { get; set; } = new List<Contact>();
    }
}
