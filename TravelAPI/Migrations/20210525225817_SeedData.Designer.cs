﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TravelAPI.Models;

namespace TravelAPI.Migrations
{
    [DbContext(typeof(TravelAPIContext))]
    [Migration("20210525225817_SeedData")]
    partial class SeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("TravelAPI.Models.Location", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<int>("Rating");

                    b.Property<string>("Review")
                        .IsRequired();

                    b.Property<string>("User_Name")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.HasKey("LocationId");

                    b.ToTable("Locations");

                    b.HasData(
                        new
                        {
                            LocationId = 1,
                            City = "Rorcek",
                            Country = "Sweden",
                            Rating = 7,
                            Review = "Wonderful and sublime. Fantastic atmostphere and amazing people.",
                            User_Name = "Malinda"
                        },
                        new
                        {
                            LocationId = 2,
                            City = "England",
                            Country = "America",
                            Rating = 2,
                            Review = "Terrible, this is not the england I was promised.",
                            User_Name = "Charlie"
                        },
                        new
                        {
                            LocationId = 3,
                            City = "Topnick",
                            Country = "Ireland",
                            Rating = 6,
                            Review = "Cold and rainy, but fantasic food and drinks!",
                            User_Name = "Derik"
                        },
                        new
                        {
                            LocationId = 4,
                            City = "Tokyo",
                            Country = "Japan",
                            Rating = 9,
                            Review = "An eastern version of New York City!",
                            User_Name = "Amy"
                        },
                        new
                        {
                            LocationId = 5,
                            City = "YorkTown",
                            Country = "England",
                            Rating = 3,
                            Review = "Don't know what I was expexting, but it wasn't this.",
                            User_Name = "Bob"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}