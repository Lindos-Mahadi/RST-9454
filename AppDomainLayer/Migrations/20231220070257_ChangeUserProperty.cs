using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppDomainLayer.Migrations
{
    public partial class ChangeUserProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Password",
                table: "User",
                newName: "PasswordHash");

            migrationBuilder.AlterColumn<string>(
                name: "Mobile",
                table: "User",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PasswordHash",
                table: "User",
                newName: "Password");

            migrationBuilder.AlterColumn<long>(
                name: "Mobile",
                table: "User",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
