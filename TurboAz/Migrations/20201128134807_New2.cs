using Microsoft.EntityFrameworkCore.Migrations;

namespace TurboAz.Migrations
{
    public partial class New2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CAR_MODEL_CAR_BRAND_BRAND_ID",
                table: "CAR_MODEL");

            migrationBuilder.AddForeignKey(
                name: "FK_CAR_MODEL_CAR_BRAND_BRAND_ID",
                table: "CAR_MODEL",
                column: "BRAND_ID",
                principalTable: "CAR_BRAND",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CAR_MODEL_CAR_BRAND_BRAND_ID",
                table: "CAR_MODEL");

            migrationBuilder.AddForeignKey(
                name: "FK_CAR_MODEL_CAR_BRAND_BRAND_ID",
                table: "CAR_MODEL",
                column: "BRAND_ID",
                principalTable: "CAR_BRAND",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
