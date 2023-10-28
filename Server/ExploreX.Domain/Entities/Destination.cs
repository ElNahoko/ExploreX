public class Destination
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string ImageURL { get; set; }
    public string VideoURL { get; set; }
    public string Country { get; set; }
    public string Region { get; set; }
    public string FunFacts { get; set; }
    public float AverageRating { get; set; }
    public ICollection<Trip> Trips { get; set; } = new List<Trip>();
    public ICollection<Review> Reviews { get; set; } = new List<Review>();
    public ICollection<Tag> Tags { get; set; } = new List<Tag>();
    public ICollection<Favorite> Favorites { get; set; } = new List<Favorite>();
}