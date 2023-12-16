using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppDomainLayer.Migrations
{
    public partial class UserModelChangeProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsRemember",
                table: "User");

            migrationBuilder.AlterColumn<long>(
                name: "Mobile",
                table: "User",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "Mobile",
                table: "User",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsRemember",
                table: "User",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
