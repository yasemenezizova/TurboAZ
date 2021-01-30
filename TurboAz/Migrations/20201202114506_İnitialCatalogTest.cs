using Microsoft.EntityFrameworkCore.Migrations;

namespace TurboAz.Migrations
{
    public partial class İnitialCatalogTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Brand_ID",
                table: "TB_ADS",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Brand_ID",
                table: "TB_ADS",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));
        }
    }
}
