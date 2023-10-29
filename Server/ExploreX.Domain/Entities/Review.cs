using ExploreX.Domain.Entities;

namespace ExploreX.Domain.Entities
{
    public class Review
    {
        public Guid Id { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
        public DateTime DatePosted { get; set; } = DateTime.UtcNow;
        public Guid UserId { get; set; }
        public User User { get; set; }
        public Guid DestinationId { get; set; }
        public Destination Destination { get; set; }
    }
}