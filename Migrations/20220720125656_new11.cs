using Microsoft.EntityFrameworkCore.Migrations;

namespace HanPerde.Migrations
{
    public partial class new11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CategoryAccessories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryAccessories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "CategoryCurtains",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryCurtains", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "AccessoryProducts",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CategoryAccessoryCategoryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccessoryProducts", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_AccessoryProducts_CategoryAccessories_CategoryAccessoryCategoryId",
                        column: x => x.CategoryAccessoryCategoryId,
                        principalTable: "CategoryAccessories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CurtainProducts",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CategoryCurtainCategoryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurtainProducts", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_CurtainProducts_CategoryCurtains_CategoryCurtainCategoryId",
                        column: x => x.CategoryCurtainCategoryId,
                        principalTable: "CategoryCurtains",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AccessoryProducts_CategoryAccessoryCategoryId",
                table: "AccessoryProducts",
                column: "CategoryAccessoryCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CurtainProducts_CategoryCurtainCategoryId",
                table: "CurtainProducts",
                column: "CategoryCurtainCategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccessoryProducts");

            migrationBuilder.DropTable(
                name: "CurtainProducts");

            migrationBuilder.DropTable(
                name: "CategoryAccessories");

            migrationBuilder.DropTable(
                name: "CategoryCurtains");
        }
    }
}
