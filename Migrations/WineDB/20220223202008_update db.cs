using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcWineAPP.Migrations.WineDB
{
    public partial class updatedb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Grape",
                columns: table => new
                {
                    GrapeID = table.Column<int>(type: "int", nullable: false),
                    WhiteGrape = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RedGrape = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rating = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grape", x => x.GrapeID);
                });

            migrationBuilder.CreateTable(
                name: "Wine",
                columns: table => new
                {
                    WineID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WineName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WineVintage = table.Column<int>(type: "int", nullable: false),
                    PairsWith = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WineType = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wine", x => x.WineID);
                });

            migrationBuilder.CreateTable(
                name: "WineType",
                columns: table => new
                {
                    WineTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WineID = table.Column<int>(type: "int", nullable: false),
                    GrapesID = table.Column<int>(type: "int", nullable: false),
                    Grade = table.Column<int>(type: "int", nullable: true),
                    GrapeID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WineType", x => x.WineTypeID);
                    table.ForeignKey(
                        name: "FK_WineType_Grape_GrapeID",
                        column: x => x.GrapeID,
                        principalTable: "Grape",
                        principalColumn: "GrapeID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WineType_Wine_WineID",
                        column: x => x.WineID,
                        principalTable: "Wine",
                        principalColumn: "WineID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WineType_GrapeID",
                table: "WineType",
                column: "GrapeID");

            migrationBuilder.CreateIndex(
                name: "IX_WineType_WineID",
                table: "WineType",
                column: "WineID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WineType");

            migrationBuilder.DropTable(
                name: "Grape");

            migrationBuilder.DropTable(
                name: "Wine");
        }
    }
}
