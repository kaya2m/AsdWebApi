using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Patch2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Menuler_Moduller_ModulId",
                table: "Menuler");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Moduller",
                table: "Moduller");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Menuler",
                table: "Menuler");

            migrationBuilder.RenameTable(
                name: "Moduller",
                newName: "ANA_Moduller");

            migrationBuilder.RenameTable(
                name: "Menuler",
                newName: "ANA_Menuler");

            migrationBuilder.RenameIndex(
                name: "IX_Menuler_ModulId",
                table: "ANA_Menuler",
                newName: "IX_ANA_Menuler_ModulId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ANA_Moduller",
                table: "ANA_Moduller",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ANA_Menuler",
                table: "ANA_Menuler",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ANA_Menuler_ANA_Moduller_ModulId",
                table: "ANA_Menuler",
                column: "ModulId",
                principalTable: "ANA_Moduller",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ANA_Menuler_ANA_Moduller_ModulId",
                table: "ANA_Menuler");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ANA_Moduller",
                table: "ANA_Moduller");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ANA_Menuler",
                table: "ANA_Menuler");

            migrationBuilder.RenameTable(
                name: "ANA_Moduller",
                newName: "Moduller");

            migrationBuilder.RenameTable(
                name: "ANA_Menuler",
                newName: "Menuler");

            migrationBuilder.RenameIndex(
                name: "IX_ANA_Menuler_ModulId",
                table: "Menuler",
                newName: "IX_Menuler_ModulId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Moduller",
                table: "Moduller",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Menuler",
                table: "Menuler",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Menuler_Moduller_ModulId",
                table: "Menuler",
                column: "ModulId",
                principalTable: "Moduller",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
