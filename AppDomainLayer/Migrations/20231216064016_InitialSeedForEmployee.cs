using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppDomainLayer.Migrations
{
    public partial class InitialSeedForEmployee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "Id", "Country", "Email", "Gender", "Name" },
                values: new object[,]
                {
                    { 1, "USA", "john.doe@example.com", "Male", "John Doe" },
                    { 2, "USA", "jane.doe@example.com", "Female", "Jane Doe" },
                    { 3, "Canada", "alice.johnson@example.com", "Female", "Alice Johnson" },
                    { 4, "UK", "bob.smith@example.com", "Male", "Bob Smith" },
                    { 5, "Australia", "eva.williams@example.com", "Female", "Eva Williams" },
                    { 6, "USA", "michael.brown@example.com", "Male", "Michael Brown" },
                    { 7, "Canada", "sophia.taylor@example.com", "Female", "Sophia Taylor" },
                    { 8, "UK", "william.davis@example.com", "Male", "William Davis" },
                    { 9, "Australia", "olivia.martinez@example.com", "Female", "Olivia Martinez" },
                    { 10, "USA", "james.johnson@example.com", "Male", "James Johnson" },
                    { 11, "Canada", "emma.brown@example.com", "Female", "Emma Brown" },
                    { 12, "UK", "liam.davis@example.com", "Male", "Liam Davis" },
                    { 13, "Australia", "ava.williams@example.com", "Female", "Ava Williams" },
                    { 14, "USA", "noah.miller@example.com", "Male", "Noah Miller" },
                    { 15, "Canada", "isabella.smith@example.com", "Female", "Isabella Smith" },
                    { 16, "UK", "mason.davis@example.com", "Male", "Mason Davis" },
                    { 17, "Australia", "sophia.wilson@example.com", "Female", "Sophia Wilson" },
                    { 18, "USA", "jackson.johnson@example.com", "Male", "Jackson Johnson" },
                    { 19, "Canada", "olivia.taylor@example.com", "Female", "Olivia Taylor" },
                    { 20, "UK", "logan.davis@example.com", "Male", "Logan Davis" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 20);
        }
    }
}
