using Microsoft.EntityFrameworkCore.Migrations;

namespace CustomerMangerAPI.Migrations
{
    public partial class slay : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "saleId",
                table: "SaleLine",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "saleId",
                table: "Customer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SaleLine_saleId",
                table: "SaleLine",
                column: "saleId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_SaleLine_Sale_saleId",
                table: "SaleLine",
                column: "saleId",
                principalTable: "Sale",
                principalColumn: "saleId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customer_Sale_saleId",
                table: "Customer");

            migrationBuilder.DropForeignKey(
                name: "FK_SaleLine_Sale_saleId",
                table: "SaleLine");

            migrationBuilder.DropIndex(
                name: "IX_SaleLine_saleId",
                table: "SaleLine");

            migrationBuilder.DropIndex(
                name: "IX_Customer_saleId",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "saleId",
                table: "SaleLine");

            migrationBuilder.DropColumn(
                name: "saleId",
                table: "Customer");
        }
    }
}
