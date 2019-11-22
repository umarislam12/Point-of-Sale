using Microsoft.EntityFrameworkCore.Migrations;

namespace CustomerMangerAPI.Migrations
{
    public partial class removeplural : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SaleLines_products_productId",
                table: "SaleLines");

            migrationBuilder.DropForeignKey(
                name: "FK_SaleLines_Sales_saleId",
                table: "SaleLines");

            migrationBuilder.DropForeignKey(
                name: "FK_Sales_Customers_id",
                table: "Sales");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sales",
                table: "Sales");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SaleLines",
                table: "SaleLines");

            migrationBuilder.DropPrimaryKey(
                name: "PK_products",
                table: "products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customers",
                table: "Customers");

            migrationBuilder.RenameTable(
                name: "Sales",
                newName: "Sale");

            migrationBuilder.RenameTable(
                name: "SaleLines",
                newName: "SaleLine");

            migrationBuilder.RenameTable(
                name: "products",
                newName: "product");

            migrationBuilder.RenameTable(
                name: "Customers",
                newName: "Customer");

            migrationBuilder.RenameIndex(
                name: "IX_Sales_id",
                table: "Sale",
                newName: "IX_Sale_id");

            migrationBuilder.RenameIndex(
                name: "IX_SaleLines_productId",
                table: "SaleLine",
                newName: "IX_SaleLine_productId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sale",
                table: "Sale",
                column: "saleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SaleLine",
                table: "SaleLine",
                columns: new[] { "saleId", "productId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_product",
                table: "product",
                column: "productId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customer",
                table: "Customer",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Sale_Customer_id",
                table: "Sale",
                column: "id",
                principalTable: "Customer",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SaleLine_product_productId",
                table: "SaleLine",
                column: "productId",
                principalTable: "product",
                principalColumn: "productId",
                onDelete: ReferentialAction.Cascade);

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
                name: "FK_Sale_Customer_id",
                table: "Sale");

            migrationBuilder.DropForeignKey(
                name: "FK_SaleLine_product_productId",
                table: "SaleLine");

            migrationBuilder.DropForeignKey(
                name: "FK_SaleLine_Sale_saleId",
                table: "SaleLine");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SaleLine",
                table: "SaleLine");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sale",
                table: "Sale");

            migrationBuilder.DropPrimaryKey(
                name: "PK_product",
                table: "product");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customer",
                table: "Customer");

            migrationBuilder.RenameTable(
                name: "SaleLine",
                newName: "SaleLines");

            migrationBuilder.RenameTable(
                name: "Sale",
                newName: "Sales");

            migrationBuilder.RenameTable(
                name: "product",
                newName: "products");

            migrationBuilder.RenameTable(
                name: "Customer",
                newName: "Customers");

            migrationBuilder.RenameIndex(
                name: "IX_SaleLine_productId",
                table: "SaleLines",
                newName: "IX_SaleLines_productId");

            migrationBuilder.RenameIndex(
                name: "IX_Sale_id",
                table: "Sales",
                newName: "IX_Sales_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SaleLines",
                table: "SaleLines",
                columns: new[] { "saleId", "productId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sales",
                table: "Sales",
                column: "saleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_products",
                table: "products",
                column: "productId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customers",
                table: "Customers",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_SaleLines_products_productId",
                table: "SaleLines",
                column: "productId",
                principalTable: "products",
                principalColumn: "productId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SaleLines_Sales_saleId",
                table: "SaleLines",
                column: "saleId",
                principalTable: "Sales",
                principalColumn: "saleId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_Customers_id",
                table: "Sales",
                column: "id",
                principalTable: "Customers",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
