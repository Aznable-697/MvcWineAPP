using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcWineAPP.Migrations.WineDB
{
    public partial class Vineyard : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WineTypes");

            migrationBuilder.DropTable(
                name: "Grape");

            migrationBuilder.AddColumn<int>(
                name: "DateAdded",
                table: "Wine",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Vineyard",
                table: "Wine",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateAdded",
                table: "Wine");

            migrationBuilder.DropColumn(
                name: "Vineyard",
                table: "Wine");

            migrationBuilder.CreateTable(
                name: "Grape",
                columns: table => new
                {
                    GrapeID = table.Column<int>(type: "int", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    RedGrape = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WhiteGrape = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grape", x => x.GrapeID);
                });

            migrationBuilder.CreateTable(
                name: "WineTypes",
                columns: table => new
                {
                    WineTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Grade = table.Column<int>(type: "int", nullable: true),
                    GrapeID = table.Column<int>(type: "int", nullable: true),
                    GrapesID = table.Column<int>(type: "int", nullable: false),
                    WineID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WineTypes", x => x.WineTypeID);
                    table.ForeignKey(
                        name: "FK_WineTypes_Grape_GrapeID",
                        column: x => x.GrapeID,
                        principalTable: "Grape",
                        principalColumn: "GrapeID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WineTypes_Wine_WineID",
                        column: x => x.WineID,
                        principalTable: "Wine",
                        principalColumn: "WineID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WineTypes_GrapeID",
                table: "WineTypes",
                column: "GrapeID");

            migrationBuilder.CreateIndex(
                name: "IX_WineTypes_WineID",
                table: "WineTypes",
                column: "WineID");
        }
    }
}
