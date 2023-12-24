using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppDomainLayer.Migrations
{
    public partial class StateSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "State",
                columns: new[] { "Id", "CountryId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "California" },
                    { 2, 1, "Texas" },
                    { 3, 2, "Ontario" },
                    { 4, 2, "Quebec" },
                    { 5, 3, "London" },
                    { 6, 3, "Manchester" },
                    { 7, 4, "Tokyo" },
                    { 8, 4, "Osaka" },
                    { 9, 5, "New South Wales" },
                    { 10, 5, "Queensland" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "State",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "State",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "State",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "State",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "State",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "State",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "State",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "State",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "State",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "State",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
