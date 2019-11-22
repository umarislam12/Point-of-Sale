using Microsoft.EntityFrameworkCore.Migrations;

namespace CustomerMangerAPI.Migrations
{
    public partial class Newforeignkeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_product_SaleLine_saleLineId",
                table: "product");

            migrationBuilder.DropForeignKey(
                name: "FK_Sale_Customer_id",
                table: "Sale");

            migrationBuilder.DropForeignKey(
                name: "FK_SaleLine_Sale_saleId",
                table: "SaleLine");

            migrationBuilder.DropIndex(
                name: "IX_SaleLine_saleId",
                table: "SaleLine");

            migrationBuilder.DropIndex(
                name: "IX_product_saleLineId",
                table: "product");

            migrationBuilder.DropColumn(
                name: "productName",
                table: "SaleLine");

            migrationBuilder.DropColumn(
                name: "saleId",
                table: "SaleLine");

            migrationBuilder.DropColumn(
                name: "saleLineId",
                table: "product");

            migrationBuilder.RenameColumn(
                name: "unitPrice",
                table: "SaleLine",
                newName: "productId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Sale",
                newName: "SaleLineId");

            migrationBuilder.RenameIndex(
                name: "IX_Sale_id",
                table: "Sale",
                newName: "IX_Sale_SaleLineId");

            migrationBuilder.AddColumn<int>(
                name: "saleId",
                table: "Customer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_SaleLine_productId",
                table: "SaleLine",
                column: "productId");

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
                name: "FK_Sale_SaleLine_SaleLineId",
                table: "Sale",
                column: "SaleLineId",
                principalTable: "SaleLine",
                principalColumn: "saleLineId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SaleLine_product_productId",
                table: "SaleLine",
                column: "productId",
                principalTable: "product",
                principalColumn: "productId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customer_Sale_saleId",
                table: "Customer");

            migrationBuilder.DropForeignKey(
                name: "FK_Sale_SaleLine_SaleLineId",
                table: "Sale");

            migrationBuilder.DropForeignKey(
                name: "FK_SaleLine_product_productId",
                table: "SaleLine");

            migrationBuilder.DropIndex(
                name: "IX_SaleLine_productId",
                table: "SaleLine");

            migrationBuilder.DropIndex(
                name: "IX_Customer_saleId",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "saleId",
                table: "Customer");

            migrationBuilder.RenameColumn(
                name: "productId",
                table: "SaleLine",
                newName: "unitPrice");

            migrationBuilder.RenameColumn(
                name: "SaleLineId",
                table: "Sale",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_Sale_SaleLineId",
                table: "Sale",
                newName: "IX_Sale_id");

            migrationBuilder.AddColumn<string>(
                name: "productName",
                table: "SaleLine",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "saleId",
                table: "SaleLine",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "saleLineId",
                table: "product",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_SaleLine_saleId",
                table: "SaleLine",
                column: "saleId");

            migrationBuilder.CreateIndex(
                name: "IX_product_saleLineId",
                table: "product",
                column: "saleLineId");

            migrationBuilder.AddForeignKey(
                name: "FK_product_SaleLine_saleLineId",
                table: "product",
                column: "saleLineId",
                principalTable: "SaleLine",
                principalColumn: "saleLineId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sale_Customer_id",
                table: "Sale",
                column: "id",
                principalTable: "Customer",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SaleLine_Sale_saleId",
                table: "SaleLine",
                column: "saleId",
                principalTable: "Sale",
                principalColumn: "saleId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
