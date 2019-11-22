using Microsoft.EntityFrameworkCore.Migrations;

namespace CustomerMangerAPI.Migrations
{
    public partial class custNvar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "dateOfBirth",
                table: "Customer",
                type: "nvarchar(10)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(10)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "dateOfBirth",
                table: "Customer",
                type: "varchar(10)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)");
        }
    }
}
