public class Tag
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public ICollection<Destination> Destinations { get; set; } = new List<Destination>();
}