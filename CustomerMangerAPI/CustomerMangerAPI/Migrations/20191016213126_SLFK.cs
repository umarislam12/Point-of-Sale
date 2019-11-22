using Microsoft.EntityFrameworkCore.Migrations;

namespace CustomerMangerAPI.Migrations
{
    public partial class SLFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customer_Sale_saleId",
                table: "Customer");

            migrationBuilder.DropForeignKey(
                name: "FK_Sale_SaleLine_saleLineId",
                table: "Sale");

            migrationBuilder.DropIndex(
                name: "IX_Sale_saleLineId",
                table: "Sale");

            migrationBuilder.DropIndex(
                name: "IX_Customer_saleId",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "saleLineId",
                table: "Sale");

            migrationBuilder.DropColumn(
                name: "saleId",
                table: "Customer");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "saleLineId",
                table: "Sale",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "saleId",
                table: "Customer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Sale_saleLineId",
                table: "Sale",
                column: "saleLineId");

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
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sale_SaleLine_saleLineId",
                table: "Sale",
                column: "saleLineId",
                principalTable: "SaleLine",
                principalColumn: "saleLineId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
