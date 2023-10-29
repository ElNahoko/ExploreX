using System.ComponentModel.DataAnnotations;

namespace ExploreX.Api.Models
{
    public class CreateDestinationRequest
    {
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        [StringLength(1000)]
        public string Description { get; set; }

        [Required]
        [Url]
        public string ImageURL { get; set; }

        [Url]
        public string VideoURL { get; set; }

        [Required]
        [StringLength(100)]
        public string Country { get; set; }

        [StringLength(100)]
        public string Region { get; set; }

        [StringLength(1000)]
        public string FunFacts { get; set; }

        [Range(0, 5)]
        public float AverageRating { get; set; }
    }
}
