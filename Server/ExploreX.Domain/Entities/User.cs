using System;
using System.Collections.Generic;
using ExploreX.Domain.Entities;

namespace ExploreX.Domain.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public DateTime DateJoined { get; set; } = DateTime.UtcNow;
        public ICollection<Trip> SavedTrips { get; set; } = new List<Trip>();
        public ICollection<Review> Reviews { get; set; } = new List<Review>();
        public ICollection<Favorite> Favorites { get; set; } = new List<Favorite>();
    }
}
