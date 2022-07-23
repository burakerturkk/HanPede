using Microsoft.EntityFrameworkCore.Migrations;

namespace HanPerde.Migrations
{
    public partial class decorativename : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AccBracolName",
                table: "AccDecoratives",
                newName: "AccDecorativeName");

            migrationBuilder.RenameColumn(
                name: "AccBracolImage",
                table: "AccDecoratives",
                newName: "AccDecorativeImage");

            migrationBuilder.RenameColumn(
                name: "AccBracolID",
                table: "AccDecoratives",
                newName: "AccDecorativeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AccDecorativeName",
                table: "AccDecoratives",
                newName: "AccBracolName");

            migrationBuilder.RenameColumn(
                name: "AccDecorativeImage",
                table: "AccDecoratives",
                newName: "AccBracolImage");

            migrationBuilder.RenameColumn(
                name: "AccDecorativeID",
                table: "AccDecoratives",
                newName: "AccBracolID");
        }
    }
}
