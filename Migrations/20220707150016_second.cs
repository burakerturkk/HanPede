using Microsoft.EntityFrameworkCore.Migrations;

namespace HanPerde.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccBracols",
                columns: table => new
                {
                    AccBracolID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccBracolName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccBracolImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccBracols", x => x.AccBracolID);
                    table.ForeignKey(
                        name: "FK_AccBracols_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AccDecoratives",
                columns: table => new
                {
                    AccBracolID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccBracolName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccBracolImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccDecoratives", x => x.AccBracolID);
                    table.ForeignKey(
                        name: "FK_AccDecoratives_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AccFringes",
                columns: table => new
                {
                    AccFringeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccFringeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccFringeImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccFringes", x => x.AccFringeId);
                    table.ForeignKey(
                        name: "FK_AccFringes_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AccRails",
                columns: table => new
                {
                    AccRailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccRailName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccRailImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccRails", x => x.AccRailId);
                    table.ForeignKey(
                        name: "FK_AccRails_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AccRensos",
                columns: table => new
                {
                    AccRensoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccRensoName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccRensoImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccRensos", x => x.AccRensoId);
                    table.ForeignKey(
                        name: "FK_AccRensos_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AccRustiks",
                columns: table => new
                {
                    AccRustikID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccRustikName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccRustikImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccRustiks", x => x.AccRustikID);
                    table.ForeignKey(
                        name: "FK_AccRustiks_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AccTassels",
                columns: table => new
                {
                    AccTasselID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccTasselName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccTasselImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccTassels", x => x.AccTasselID);
                    table.ForeignKey(
                        name: "FK_AccTassels_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CurtainFons",
                columns: table => new
                {
                    CurtainFonID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CurtainFonName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CurtainFonImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurtainFons", x => x.CurtainFonID);
                    table.ForeignKey(
                        name: "FK_CurtainFons_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CurtainJaluzis",
                columns: table => new
                {
                    CurtainJaluziID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CurtainJaluziName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CurtainJaluziImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurtainJaluzis", x => x.CurtainJaluziID);
                    table.ForeignKey(
                        name: "FK_CurtainJaluzis_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CurtainMetalJaluzis",
                columns: table => new
                {
                    CurtainMetalJaluziID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CurtainMetalJaluziName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CurtainMetalJaluziImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurtainMetalJaluzis", x => x.CurtainMetalJaluziID);
                    table.ForeignKey(
                        name: "FK_CurtainMetalJaluzis_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CurtainPlisels",
                columns: table => new
                {
                    CurtainPliselID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CurtainPliselName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CurtainPliselImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurtainPlisels", x => x.CurtainPliselID);
                    table.ForeignKey(
                        name: "FK_CurtainPlisels_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CurtainStores",
                columns: table => new
                {
                    CurtainStoreID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CurtainStoreName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CurtainStoreImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurtainStores", x => x.CurtainStoreID);
                    table.ForeignKey(
                        name: "FK_CurtainStores_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CurtainTulles",
                columns: table => new
                {
                    CurtainTulleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CurtainTulleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CurtainTulleImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurtainTulles", x => x.CurtainTulleID);
                    table.ForeignKey(
                        name: "FK_CurtainTulles_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CurtainVerticals",
                columns: table => new
                {
                    CurtainVerticalID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CurtainVerticalName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CurtainVerticalImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurtainVerticals", x => x.CurtainVerticalID);
                    table.ForeignKey(
                        name: "FK_CurtainVerticals_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CurtainZebras",
                columns: table => new
                {
                    CurtainZebraID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CurtainZebraName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CurtainZebraImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurtainZebras", x => x.CurtainZebraID);
                    table.ForeignKey(
                        name: "FK_CurtainZebras_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AccBracols_CategoryId",
                table: "AccBracols",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_AccDecoratives_CategoryId",
                table: "AccDecoratives",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_AccFringes_CategoryId",
                table: "AccFringes",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_AccRails_CategoryId",
                table: "AccRails",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_AccRensos_CategoryId",
                table: "AccRensos",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_AccRustiks_CategoryId",
                table: "AccRustiks",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_AccTassels_CategoryId",
                table: "AccTassels",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CurtainFons_CategoryId",
                table: "CurtainFons",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CurtainJaluzis_CategoryId",
                table: "CurtainJaluzis",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CurtainMetalJaluzis_CategoryId",
                table: "CurtainMetalJaluzis",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CurtainPlisels_CategoryId",
                table: "CurtainPlisels",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CurtainStores_CategoryId",
                table: "CurtainStores",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CurtainTulles_CategoryId",
                table: "CurtainTulles",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CurtainVerticals_CategoryId",
                table: "CurtainVerticals",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CurtainZebras_CategoryId",
                table: "CurtainZebras",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccBracols");

            migrationBuilder.DropTable(
                name: "AccDecoratives");

            migrationBuilder.DropTable(
                name: "AccFringes");

            migrationBuilder.DropTable(
                name: "AccRails");

            migrationBuilder.DropTable(
                name: "AccRensos");

            migrationBuilder.DropTable(
                name: "AccRustiks");

            migrationBuilder.DropTable(
                name: "AccTassels");

            migrationBuilder.DropTable(
                name: "CurtainFons");

            migrationBuilder.DropTable(
                name: "CurtainJaluzis");

            migrationBuilder.DropTable(
                name: "CurtainMetalJaluzis");

            migrationBuilder.DropTable(
                name: "CurtainPlisels");

            migrationBuilder.DropTable(
                name: "CurtainStores");

            migrationBuilder.DropTable(
                name: "CurtainTulles");

            migrationBuilder.DropTable(
                name: "CurtainVerticals");

            migrationBuilder.DropTable(
                name: "CurtainZebras");
        }
    }
}
