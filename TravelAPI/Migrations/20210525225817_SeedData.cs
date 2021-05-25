using Microsoft.EntityFrameworkCore.Migrations;

namespace TravelAPI.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 5);
        }
    }
}
