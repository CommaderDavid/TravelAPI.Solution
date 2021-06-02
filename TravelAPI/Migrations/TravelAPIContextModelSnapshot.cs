﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TravelAPI.Models;

namespace TravelAPI.Migrations
{
    [DbContext(typeof(TravelAPIContext))]
    partial class TravelAPIContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("TravelAPI.Models.Review", b =>
                {
                    b.Property<int>("ReviewId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<int>("Rating");

                    b.Property<string>("UserReview")
                        .IsRequired();

                    b.Property<string>("User_Name")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.HasKey("ReviewId");

                    b.ToTable("Reviews");

                    b.HasData(
                        new
                        {
                            ReviewId = 1,
                            City = "Rorcek",
                            Country = "Sweden",
                            Rating = 7,
                            UserReview = "Wonderful and sublime. Fantastic atmostphere and amazing people.",
                            User_Name = "Malinda"
                        },
                        new
                        {
                            ReviewId = 2,
                            City = "England",
                            Country = "America",
                            Rating = 2,
                            UserReview = "Terrible, this is not the england I was promised.",
                            User_Name = "Charlie"
                        },
                        new
                        {
                            ReviewId = 3,
                            City = "Topnick",
                            Country = "Ireland",
                            Rating = 6,
                            UserReview = "Cold and rainy, but fantasic food and drinks!",
                            User_Name = "Derik"
                        },
                        new
                        {
                            ReviewId = 4,
                            City = "Tokyo",
                            Country = "Japan",
                            Rating = 9,
                            UserReview = "An eastern version of New York City!",
                            User_Name = "Amy"
                        },
                        new
                        {
                            ReviewId = 5,
                            City = "YorkTown",
                            Country = "England",
                            Rating = 3,
                            UserReview = "Don't know what I was expexting, but it wasn't this.",
                            User_Name = "Bob"
                        },
                        new
                        {
                            ReviewId = 6,
                            City = "Tokyo",
                            Country = "Japan",
                            Rating = 7,
                            UserReview = "Nice place. Perfect for the busy city life that I enjoy.",
                            User_Name = "Bob"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
