using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppDomainLayer.Migrations
{
    public partial class CitySeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "Id", "CityName", "StateId" },
                values: new object[,]
                {
                    { 1, "City 1", 1 },
                    { 2, "City 2", 1 },
                    { 3, "City 3", 2 },
                    { 4, "City 4", 2 },
                    { 5, "City 5", 3 },
                    { 6, "City 6", 3 },
                    { 7, "City 7", 4 },
                    { 8, "City 8", 4 },
                    { 9, "City 9", 5 },
                    { 10, "City 10", 5 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
