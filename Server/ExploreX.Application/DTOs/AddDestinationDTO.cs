using System;

namespace ExploreX.Application.DTOs
{
    public class AddDestinationDTO
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string ImageURL { get; set; }

        public string VideoURL { get; set; }

        public string Country { get; set; }

        public string Region { get; set; }

        public string FunFacts { get; set; }

        public float AverageRating { get; set; }
    }
}