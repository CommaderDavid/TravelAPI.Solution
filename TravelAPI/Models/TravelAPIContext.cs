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

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Location>()
              .HasData(
                new Location { LocationId = 1, User_Name = "Malinda", Country = "Sweden", City = "Rorcek", Review = "Wonderful and sublime. Fantastic atmostphere and amazing people.", Rating = 7 },
                new Location { LocationId = 2, User_Name = "Charlie", Country = "America", City = "England", Review = "Terrible, this is not the england I was promised.", Rating = 2 },
                new Location { LocationId = 3, User_Name = "Derik", Country = "Ireland", City = "Topnick", Review = "Cold and rainy, but fantasic food and drinks!", Rating = 6 },
                new Location { LocationId = 4, User_Name = "Amy", Country = "Japan", City = "Tokyo", Review = "An eastern version of New York City!", Rating = 9 },
                new Location { LocationId = 5, User_Name = "Bob", Country = "England", City = "YorkTown", Review = "Don't know what I was expexting, but it wasn't this.", Rating = 3 }
            );
        }
    }
}