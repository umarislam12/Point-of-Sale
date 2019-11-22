using Microsoft.EntityFrameworkCore.Migrations;

namespace CustomerMangerAPI.Migrations
{
    public partial class AddingUnitPrice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "unitPrice",
                table: "product",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "unitPrice",
                table: "product");
        }
    }
}
