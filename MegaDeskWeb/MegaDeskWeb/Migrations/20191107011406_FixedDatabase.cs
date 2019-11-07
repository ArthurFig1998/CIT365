using Microsoft.EntityFrameworkCore.Migrations;

namespace MegaDeskWeb.Migrations
{
    public partial class FixedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "SurfaceMaterialName",
                table: "SurfaceMaterial",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "SurfaceMaterialName",
                table: "SurfaceMaterial",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
