namespace carrocerias.models
{
    public class BodytruckCategory
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public ICollection<Bodytruck> Bodytrucks { get; set; } = new List<Bodytruck>();
    }
}
