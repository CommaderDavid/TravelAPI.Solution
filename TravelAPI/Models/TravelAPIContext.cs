using Microsoft.EntityFrameworkCore;

namespace TravelAPI.Models
{
    public class TravelAPIContext : DbContext
    {
        public DbSet<Location> Locations { get; set; }

        public TravelAPIContext(DbContextOptions<TravelAPIContext> options)
          : base(options)
        {
        }
    }
}