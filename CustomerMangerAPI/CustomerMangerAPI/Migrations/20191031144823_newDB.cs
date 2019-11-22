using Microsoft.EntityFrameworkCore.Migrations;

namespace CustomerMangerAPI.Migrations
{
    public partial class newDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customer_Sale_saleId",
                table: "Customer");

            migrationBuilder.DropIndex(
                name: "IX_Customer_saleId",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "saleId",
                table: "Customer");

            migrationBuilder.AddColumn<int>(
                name: "id",
                table: "Sale",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "saleNo",
                table: "Sale",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "productCode",
                table: "product",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Sale_id",
                table: "Sale",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Sale_Customer_id",
                table: "Sale",
                column: "id",
                principalTable: "Customer",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sale_Customer_id",
                table: "Sale");

            migrationBuilder.DropIndex(
                name: "IX_Sale_id",
                table: "Sale");

            migrationBuilder.DropColumn(
                name: "id",
                table: "Sale");

            migrationBuilder.DropColumn(
                name: "saleNo",
                table: "Sale");

            migrationBuilder.DropColumn(
                name: "productCode",
                table: "product");

            migrationBuilder.AddColumn<int>(
                name: "saleId",
                table: "Customer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Customer_saleId",
                table: "Customer",
                column: "saleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_Sale_saleId",
                table: "Customer",
                column: "saleId",
                principalTable: "Sale",
                principalColumn: "saleId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
