using System.ComponentModel.DataAnnotations;

namespace TravelAPI.Models
{
    public class Location
    {
        public int LocationId { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Review { get; set; }
        public int Rating { get; set; }
    }
}