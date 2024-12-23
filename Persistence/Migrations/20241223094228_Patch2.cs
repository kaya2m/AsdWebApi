using System;
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
                name: "FK_Menuler_OnYuz_Yetkiler_YetkilerId",
                table: "Menuler");

            migrationBuilder.DropForeignKey(
                name: "FK_Moduller_OnYuz_Yetkiler_YetkilerId",
                table: "Moduller");

            migrationBuilder.DropTable(
                name: "OnYuz_Yetkiler");

            migrationBuilder.DropIndex(
                name: "IX_Moduller_YetkilerId",
                table: "Moduller");

            migrationBuilder.DropIndex(
                name: "IX_Menuler_YetkilerId",
                table: "Menuler");

            migrationBuilder.DropColumn(
                name: "YetkilerId",
                table: "Moduller");

            migrationBuilder.DropColumn(
                name: "YetkilerId",
                table: "Menuler");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "YetkilerId",
                table: "Moduller",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "YetkilerId",
                table: "Menuler",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "OnYuz_Yetkiler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Kullanici_GrupId = table.Column<int>(type: "int", nullable: false),
                    Modul_Id = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    View_Id = table.Column<int>(type: "int", nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OnYuz_Yetkiler", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Moduller_YetkilerId",
                table: "Moduller",
                column: "YetkilerId");

            migrationBuilder.CreateIndex(
                name: "IX_Menuler_YetkilerId",
                table: "Menuler",
                column: "YetkilerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Menuler_OnYuz_Yetkiler_YetkilerId",
                table: "Menuler",
                column: "YetkilerId",
                principalTable: "OnYuz_Yetkiler",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Moduller_OnYuz_Yetkiler_YetkilerId",
                table: "Moduller",
                column: "YetkilerId",
                principalTable: "OnYuz_Yetkiler",
                principalColumn: "Id");
        }
    }
}
