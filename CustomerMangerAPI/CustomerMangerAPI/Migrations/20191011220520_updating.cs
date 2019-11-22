using Microsoft.EntityFrameworkCore.Migrations;

namespace CustomerMangerAPI.Migrations
{
    public partial class updating : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sale_SaleLine_SaleLineId",
                table: "Sale");

            migrationBuilder.RenameColumn(
                name: "SaleLineId",
                table: "Sale",
                newName: "saleLineId");

            migrationBuilder.RenameIndex(
                name: "IX_Sale_SaleLineId",
                table: "Sale",
                newName: "IX_Sale_saleLineId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sale_SaleLine_saleLineId",
                table: "Sale",
                column: "saleLineId",
                principalTable: "SaleLine",
                principalColumn: "saleLineId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sale_SaleLine_saleLineId",
                table: "Sale");

            migrationBuilder.RenameColumn(
                name: "saleLineId",
                table: "Sale",
                newName: "SaleLineId");

            migrationBuilder.RenameIndex(
                name: "IX_Sale_saleLineId",
                table: "Sale",
                newName: "IX_Sale_SaleLineId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sale_SaleLine_SaleLineId",
                table: "Sale",
                column: "SaleLineId",
                principalTable: "SaleLine",
                principalColumn: "saleLineId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
