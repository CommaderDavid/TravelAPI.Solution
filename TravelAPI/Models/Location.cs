using System.ComponentModel.DataAnnotations;

namespace TravelAPI.Models
{
    public class Review
    {
        public int ReviewId { get; set; }
        [Required]
        [StringLength(30)]
        public string User_Name { get; set; }
        [Required]
        [StringLength(20)]
        public string Country { get; set; }
        [Required]
        [StringLength(20)]
        public string City { get; set; }
        [Required]
        public string UserReview { get; set; }
        [Required]
        [Range(0, 10, ErrorMessage = "Rating must be between 0 and 10.")]
        public int Rating { get; set; }
    }
}