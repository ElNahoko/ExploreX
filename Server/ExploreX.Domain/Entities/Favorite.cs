using ExploreX.Domain.Entities;

namespace ExploreX.Domain.Entities
{
    public class Favorite
    {
        public Guid Id { get; set; }
        public DateTime DateAdded { get; set; } = DateTime.UtcNow;
        public Guid UserId { get; set; }
        public User User { get; set; }
        public Guid DestinationId { get; set; }
        public Destination Destination { get; set; }
    }
}