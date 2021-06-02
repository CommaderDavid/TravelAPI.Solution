using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TravelAPI.Migrations
{
    public partial class SeedRename : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    ReviewId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    User_Name = table.Column<string>(maxLength: 30, nullable: false),
                    Country = table.Column<string>(maxLength: 20, nullable: false),
                    City = table.Column<string>(maxLength: 20, nullable: false),
                    UserReview = table.Column<string>(nullable: false),
                    Rating = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.ReviewId);
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "City", "Country", "Rating", "UserReview", "User_Name" },
                values: new object[,]
                {
                    { 1, "Rorcek", "Sweden", 7, "Wonderful and sublime. Fantastic atmostphere and amazing people.", "Malinda" },
                    { 2, "England", "America", 2, "Terrible, this is not the england I was promised.", "Charlie" },
                    { 3, "Topnick", "Ireland", 6, "Cold and rainy, but fantasic food and drinks!", "Derik" },
                    { 4, "Tokyo", "Japan", 9, "An eastern version of New York City!", "Amy" },
                    { 5, "YorkTown", "England", 3, "Don't know what I was expexting, but it wasn't this.", "Bob" },
                    { 6, "Tokyo", "Japan", 7, "Nice place. Perfect for the busy city life that I enjoy.", "Bob" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    LocationId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    City = table.Column<string>(maxLength: 20, nullable: false),
                    Country = table.Column<string>(maxLength: 20, nullable: false),
                    Rating = table.Column<int>(nullable: false),
                    Review = table.Column<string>(nullable: false),
                    User_Name = table.Column<string>(maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.LocationId);
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "LocationId", "City", "Country", "Rating", "Review", "User_Name" },
                values: new object[,]
                {
                    { 1, "Rorcek", "Sweden", 7, "Wonderful and sublime. Fantastic atmostphere and amazing people.", "Malinda" },
                    { 2, "England", "America", 2, "Terrible, this is not the england I was promised.", "Charlie" },
                    { 3, "Topnick", "Ireland", 6, "Cold and rainy, but fantasic food and drinks!", "Derik" },
                    { 4, "Tokyo", "Japan", 9, "An eastern version of New York City!", "Amy" },
                    { 5, "YorkTown", "England", 3, "Don't know what I was expexting, but it wasn't this.", "Bob" }
                });
        }
    }
}
