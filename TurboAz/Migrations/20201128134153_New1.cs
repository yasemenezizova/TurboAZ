using Microsoft.EntityFrameworkCore.Migrations;

namespace TurboAz.Migrations
{
    public partial class New1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CAR_BRAND",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BRAND_CODE = table.Column<string>(nullable: true),
                    BRAND_NAME = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CAR_BRAND", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "GENERAL_TYPE",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NAME = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GENERAL_TYPE", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CAR_MODEL",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MODEL_NAME = table.Column<string>(nullable: true),
                    MODEL_CODE = table.Column<string>(nullable: true),
                    BRAND_ID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CAR_MODEL", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CAR_MODEL_CAR_BRAND_BRAND_ID",
                        column: x => x.BRAND_ID,
                        principalTable: "CAR_BRAND",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GENERAL_INFO",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NAME = table.Column<string>(nullable: true),
                    TYPE_ID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GENERAL_INFO", x => x.ID);
                    table.ForeignKey(
                        name: "FK_GENERAL_INFO_GENERAL_TYPE_TYPE_ID",
                        column: x => x.TYPE_ID,
                        principalTable: "GENERAL_TYPE",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TB_ADS",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Brand_ID = table.Column<int>(nullable: false),
                    Model_ID = table.Column<int>(nullable: false),
                    Body_Type_ID = table.Column<int>(nullable: false),
                    Walk = table.Column<int>(nullable: false),
                    Color_ID = table.Column<int>(nullable: false),
                    Price = table.Column<int>(nullable: false),
                    Currency_ID = table.Column<int>(nullable: false),
                    Credit = table.Column<bool>(nullable: false),
                    Barter = table.Column<bool>(nullable: false),
                    Fuel_Type_ID = table.Column<int>(nullable: false),
                    Transmission_ID = table.Column<int>(nullable: false),
                    Gearbox_ID = table.Column<int>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    NOTE = table.Column<string>(nullable: true),
                    Engine_Capacity_ID = table.Column<int>(nullable: false),
                    Engine_Power = table.Column<int>(nullable: false),
                    ALLOY_WHEELS = table.Column<bool>(nullable: false),
                    CENTRAL_CLOSURE = table.Column<bool>(nullable: false),
                    LEATHER_SALON = table.Column<bool>(nullable: false),
                    SEAT_VENTILATION = table.Column<bool>(nullable: false),
                    ABS = table.Column<bool>(nullable: false),
                    PARKING_RADAR = table.Column<bool>(nullable: false),
                    XENON_LAMPS = table.Column<bool>(nullable: false),
                    LUKE = table.Column<bool>(nullable: false),
                    CONDITIONERS = table.Column<bool>(nullable: false),
                    REAR_VIEW_CAMERA = table.Column<bool>(nullable: false),
                    RAIN_SENSOR = table.Column<bool>(nullable: false),
                    SEAT_HEATING = table.Column<bool>(nullable: false),
                    SIDE_CURTAINS = table.Column<bool>(nullable: false),
                    NAME = table.Column<string>(nullable: true),
                    CITY_ID = table.Column<int>(nullable: false),
                    EMAIL = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_ADS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TB_ADS_GENERAL_INFO_Body_Type_ID",
                        column: x => x.Body_Type_ID,
                        principalTable: "GENERAL_INFO",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TB_ADS_CAR_BRAND_Brand_ID",
                        column: x => x.Brand_ID,
                        principalTable: "CAR_BRAND",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TB_ADS_GENERAL_INFO_CITY_ID",
                        column: x => x.CITY_ID,
                        principalTable: "GENERAL_INFO",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TB_ADS_GENERAL_INFO_Color_ID",
                        column: x => x.Color_ID,
                        principalTable: "GENERAL_INFO",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TB_ADS_GENERAL_INFO_Fuel_Type_ID",
                        column: x => x.Fuel_Type_ID,
                        principalTable: "GENERAL_INFO",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TB_ADS_GENERAL_INFO_Gearbox_ID",
                        column: x => x.Gearbox_ID,
                        principalTable: "GENERAL_INFO",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TB_ADS_CAR_MODEL_Model_ID",
                        column: x => x.Model_ID,
                        principalTable: "CAR_MODEL",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TB_ADS_GENERAL_INFO_Transmission_ID",
                        column: x => x.Transmission_ID,
                        principalTable: "GENERAL_INFO",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TB_ADS_IMAGE",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CAR_IMAGE = table.Column<int>(nullable: false),
                    ADS_ID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_ADS_IMAGE", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TB_ADS_IMAGE_TB_ADS_ADS_ID",
                        column: x => x.ADS_ID,
                        principalTable: "TB_ADS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CAR_MODEL_BRAND_ID",
                table: "CAR_MODEL",
                column: "BRAND_ID");

            migrationBuilder.CreateIndex(
                name: "IX_GENERAL_INFO_TYPE_ID",
                table: "GENERAL_INFO",
                column: "TYPE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TB_ADS_Body_Type_ID",
                table: "TB_ADS",
                column: "Body_Type_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TB_ADS_Brand_ID",
                table: "TB_ADS",
                column: "Brand_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TB_ADS_CITY_ID",
                table: "TB_ADS",
                column: "CITY_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TB_ADS_Color_ID",
                table: "TB_ADS",
                column: "Color_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TB_ADS_Fuel_Type_ID",
                table: "TB_ADS",
                column: "Fuel_Type_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TB_ADS_Gearbox_ID",
                table: "TB_ADS",
                column: "Gearbox_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TB_ADS_Model_ID",
                table: "TB_ADS",
                column: "Model_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TB_ADS_Transmission_ID",
                table: "TB_ADS",
                column: "Transmission_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TB_ADS_IMAGE_ADS_ID",
                table: "TB_ADS_IMAGE",
                column: "ADS_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_ADS_IMAGE");

            migrationBuilder.DropTable(
                name: "TB_ADS");

            migrationBuilder.DropTable(
                name: "GENERAL_INFO");

            migrationBuilder.DropTable(
                name: "CAR_MODEL");

            migrationBuilder.DropTable(
                name: "GENERAL_TYPE");

            migrationBuilder.DropTable(
                name: "CAR_BRAND");
        }
    }
}
