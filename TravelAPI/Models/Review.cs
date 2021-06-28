using System.ComponentModel.DataAnnotations;

namespace TravelAPI.Models
{
    public class Review
    {
        public int ReviewId { get; set; }
        [Required]
        [StringLength(30)]
        public string UserName { get; set; }
        [Required]
        [StringLength(20)]
        public string UserPassword { get; set; }
        [Required]
        [StringLength(10)]
        public string UserRole { get; set; }
        [Required]
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