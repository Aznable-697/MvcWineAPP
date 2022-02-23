using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcWineAPP.Migrations.WineDB
{
    public partial class newtables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WineType_Grape_GrapeID",
                table: "WineType");

            migrationBuilder.DropForeignKey(
                name: "FK_WineType_Wine_WineID",
                table: "WineType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WineType",
                table: "WineType");

            migrationBuilder.RenameTable(
                name: "WineType",
                newName: "WineTypes");

            migrationBuilder.RenameColumn(
                name: "WineType",
                table: "Wine",
                newName: "WineTypes");

            migrationBuilder.RenameIndex(
                name: "IX_WineType_WineID",
                table: "WineTypes",
                newName: "IX_WineTypes_WineID");

            migrationBuilder.RenameIndex(
                name: "IX_WineType_GrapeID",
                table: "WineTypes",
                newName: "IX_WineTypes_GrapeID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WineTypes",
                table: "WineTypes",
                column: "WineTypeID");

            migrationBuilder.AddForeignKey(
                name: "FK_WineTypes_Grape_GrapeID",
                table: "WineTypes",
                column: "GrapeID",
                principalTable: "Grape",
                principalColumn: "GrapeID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WineTypes_Wine_WineID",
                table: "WineTypes",
                column: "WineID",
                principalTable: "Wine",
                principalColumn: "WineID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WineTypes_Grape_GrapeID",
                table: "WineTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_WineTypes_Wine_WineID",
                table: "WineTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WineTypes",
                table: "WineTypes");

            migrationBuilder.RenameTable(
                name: "WineTypes",
                newName: "WineType");

            migrationBuilder.RenameColumn(
                name: "WineTypes",
                table: "Wine",
                newName: "WineType");

            migrationBuilder.RenameIndex(
                name: "IX_WineTypes_WineID",
                table: "WineType",
                newName: "IX_WineType_WineID");

            migrationBuilder.RenameIndex(
                name: "IX_WineTypes_GrapeID",
                table: "WineType",
                newName: "IX_WineType_GrapeID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WineType",
                table: "WineType",
                column: "WineTypeID");

            migrationBuilder.AddForeignKey(
                name: "FK_WineType_Grape_GrapeID",
                table: "WineType",
                column: "GrapeID",
                principalTable: "Grape",
                principalColumn: "GrapeID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WineType_Wine_WineID",
                table: "WineType",
                column: "WineID",
                principalTable: "Wine",
                principalColumn: "WineID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
