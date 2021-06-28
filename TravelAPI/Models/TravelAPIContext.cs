using Microsoft.EntityFrameworkCore;

namespace TravelAPI.Models
{
    public class TravelAPIContext : DbContext
    {
        public DbSet<Review> Reviews { get; set; }

        public TravelAPIContext(DbContextOptions<TravelAPIContext> options)
          : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Review>()
              .HasData(
                new Review { ReviewId = 1, UserName = "Malinda", Country = "Sweden", City = "Rorcek", UserReview = "Wonderful and sublime. Fantastic atmostphere and amazing people.", Rating = 7 },
                new Review { ReviewId = 2, UserName = "Charlie", Country = "America", City = "England", UserReview = "Terrible, this is not the england I was promised.", Rating = 2 },
                new Review { ReviewId = 3, UserName = "Derik", Country = "Ireland", City = "Topnick", UserReview = "Cold and rainy, but fantasic food and drinks!", Rating = 6 },
                new Review { ReviewId = 4, UserName = "Amy", Country = "Japan", City = "Tokyo", UserReview = "An eastern version of New York City!", Rating = 9 },
                new Review { ReviewId = 5, UserName = "Bob", Country = "England", City = "YorkTown", UserReview = "Don't know what I was expexting, but it wasn't this.", Rating = 3 },
                new Review { ReviewId = 6, UserName = "Bob", Country = "Japan", City = "Tokyo", UserReview = "Nice place. Perfect for the busy city life that I enjoy.", Rating = 7 }
            );
        }
    }
}