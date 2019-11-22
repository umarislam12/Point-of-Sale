using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CustomerMangerAPI.Migrations
{
    public partial class addingNewTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sale",
                columns: table => new
                {
                    saleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    saleDate = table.Column<string>(nullable: true),
                    id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sale", x => x.saleId);
                    table.ForeignKey(
                        name: "FK_Sale_Customer_id",
                        column: x => x.id,
                        principalTable: "Customer",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SaleLine",
                columns: table => new
                {
                    saleLineId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    productName = table.Column<string>(nullable: true),
                    quantity = table.Column<string>(nullable: true),
                    unitPrice = table.Column<int>(nullable: false),
                    totalQuantity = table.Column<int>(nullable: false),
                    saleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaleLine", x => x.saleLineId);
                    table.ForeignKey(
                        name: "FK_SaleLine_Sale_saleId",
                        column: x => x.saleId,
                        principalTable: "Sale",
                        principalColumn: "saleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sale_id",
                table: "Sale",
                column: "id");

            migrationBuilder.CreateIndex(
                name: "IX_SaleLine_saleId",
                table: "SaleLine",
                column: "saleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SaleLine");

            migrationBuilder.DropTable(
                name: "Sale");
        }
    }
}
