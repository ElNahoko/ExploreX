using ExploreX.Api.Models;

public class Trip
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string Notes { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
        public Guid DestinationId { get; set; }
        public Destination Destination { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;
    }