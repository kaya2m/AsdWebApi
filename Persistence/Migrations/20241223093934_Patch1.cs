using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Patch1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kullanicilars_Birimlers_Birim_Id",
                table: "Kullanicilars");

            migrationBuilder.DropForeignKey(
                name: "FK_Kullanicilars_Gorevlers_Gorev_Id",
                table: "Kullanicilars");

            migrationBuilder.DropForeignKey(
                name: "FK_Kullanicilars_Gruplars_GruplarId",
                table: "Kullanicilars");

            migrationBuilder.DropForeignKey(
                name: "FK_Menulers_Modullers_Modul_Id",
                table: "Menulers");

            migrationBuilder.DropForeignKey(
                name: "FK_Menulers_OnYuz_Yetkiler_YetkilerId",
                table: "Menulers");

            migrationBuilder.DropForeignKey(
                name: "FK_Modullers_OnYuz_Yetkiler_YetkilerId",
                table: "Modullers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Modullers",
                table: "Modullers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Menulers",
                table: "Menulers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Kullanicilars",
                table: "Kullanicilars");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Gruplars",
                table: "Gruplars");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Gorevlers",
                table: "Gorevlers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Birimlers",
                table: "Birimlers");

            migrationBuilder.RenameTable(
                name: "Modullers",
                newName: "Moduller");

            migrationBuilder.RenameTable(
                name: "Menulers",
                newName: "Menuler");

            migrationBuilder.RenameTable(
                name: "Kullanicilars",
                newName: "Kullanicilar");

            migrationBuilder.RenameTable(
                name: "Gruplars",
                newName: "Gruplar");

            migrationBuilder.RenameTable(
                name: "Gorevlers",
                newName: "Gorevler");

            migrationBuilder.RenameTable(
                name: "Birimlers",
                newName: "Birimler");

            migrationBuilder.RenameIndex(
                name: "IX_Modullers_YetkilerId",
                table: "Moduller",
                newName: "IX_Moduller_YetkilerId");

            migrationBuilder.RenameIndex(
                name: "IX_Menulers_YetkilerId",
                table: "Menuler",
                newName: "IX_Menuler_YetkilerId");

            migrationBuilder.RenameIndex(
                name: "IX_Menulers_Modul_Id",
                table: "Menuler",
                newName: "IX_Menuler_Modul_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Kullanicilars_GruplarId",
                table: "Kullanicilar",
                newName: "IX_Kullanicilar_GruplarId");

            migrationBuilder.RenameIndex(
                name: "IX_Kullanicilars_Gorev_Id",
                table: "Kullanicilar",
                newName: "IX_Kullanicilar_Gorev_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Kullanicilars_Birim_Id",
                table: "Kullanicilar",
                newName: "IX_Kullanicilar_Birim_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Moduller",
                table: "Moduller",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Menuler",
                table: "Menuler",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Kullanicilar",
                table: "Kullanicilar",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Gruplar",
                table: "Gruplar",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Gorevler",
                table: "Gorevler",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Birimler",
                table: "Birimler",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Kullanicilar_Birimler_Birim_Id",
                table: "Kullanicilar",
                column: "Birim_Id",
                principalTable: "Birimler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Kullanicilar_Gorevler_Gorev_Id",
                table: "Kullanicilar",
                column: "Gorev_Id",
                principalTable: "Gorevler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Kullanicilar_Gruplar_GruplarId",
                table: "Kullanicilar",
                column: "GruplarId",
                principalTable: "Gruplar",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Menuler_Moduller_Modul_Id",
                table: "Menuler",
                column: "Modul_Id",
                principalTable: "Moduller",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kullanicilar_Birimler_Birim_Id",
                table: "Kullanicilar");

            migrationBuilder.DropForeignKey(
                name: "FK_Kullanicilar_Gorevler_Gorev_Id",
                table: "Kullanicilar");

            migrationBuilder.DropForeignKey(
                name: "FK_Kullanicilar_Gruplar_GruplarId",
                table: "Kullanicilar");

            migrationBuilder.DropForeignKey(
                name: "FK_Menuler_Moduller_Modul_Id",
                table: "Menuler");

            migrationBuilder.DropForeignKey(
                name: "FK_Menuler_OnYuz_Yetkiler_YetkilerId",
                table: "Menuler");

            migrationBuilder.DropForeignKey(
                name: "FK_Moduller_OnYuz_Yetkiler_YetkilerId",
                table: "Moduller");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Moduller",
                table: "Moduller");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Menuler",
                table: "Menuler");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Kullanicilar",
                table: "Kullanicilar");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Gruplar",
                table: "Gruplar");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Gorevler",
                table: "Gorevler");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Birimler",
                table: "Birimler");

            migrationBuilder.RenameTable(
                name: "Moduller",
                newName: "Modullers");

            migrationBuilder.RenameTable(
                name: "Menuler",
                newName: "Menulers");

            migrationBuilder.RenameTable(
                name: "Kullanicilar",
                newName: "Kullanicilars");

            migrationBuilder.RenameTable(
                name: "Gruplar",
                newName: "Gruplars");

            migrationBuilder.RenameTable(
                name: "Gorevler",
                newName: "Gorevlers");

            migrationBuilder.RenameTable(
                name: "Birimler",
                newName: "Birimlers");

            migrationBuilder.RenameIndex(
                name: "IX_Moduller_YetkilerId",
                table: "Modullers",
                newName: "IX_Modullers_YetkilerId");

            migrationBuilder.RenameIndex(
                name: "IX_Menuler_YetkilerId",
                table: "Menulers",
                newName: "IX_Menulers_YetkilerId");

            migrationBuilder.RenameIndex(
                name: "IX_Menuler_Modul_Id",
                table: "Menulers",
                newName: "IX_Menulers_Modul_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Kullanicilar_GruplarId",
                table: "Kullanicilars",
                newName: "IX_Kullanicilars_GruplarId");

            migrationBuilder.RenameIndex(
                name: "IX_Kullanicilar_Gorev_Id",
                table: "Kullanicilars",
                newName: "IX_Kullanicilars_Gorev_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Kullanicilar_Birim_Id",
                table: "Kullanicilars",
                newName: "IX_Kullanicilars_Birim_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Modullers",
                table: "Modullers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Menulers",
                table: "Menulers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Kullanicilars",
                table: "Kullanicilars",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Gruplars",
                table: "Gruplars",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Gorevlers",
                table: "Gorevlers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Birimlers",
                table: "Birimlers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Kullanicilars_Birimlers_Birim_Id",
                table: "Kullanicilars",
                column: "Birim_Id",
                principalTable: "Birimlers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Kullanicilars_Gorevlers_Gorev_Id",
                table: "Kullanicilars",
                column: "Gorev_Id",
                principalTable: "Gorevlers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Kullanicilars_Gruplars_GruplarId",
                table: "Kullanicilars",
                column: "GruplarId",
                principalTable: "Gruplars",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Menulers_Modullers_Modul_Id",
                table: "Menulers",
                column: "Modul_Id",
                principalTable: "Modullers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Menulers_OnYuz_Yetkiler_YetkilerId",
                table: "Menulers",
                column: "YetkilerId",
                principalTable: "OnYuz_Yetkiler",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Modullers_OnYuz_Yetkiler_YetkilerId",
                table: "Modullers",
                column: "YetkilerId",
                principalTable: "OnYuz_Yetkiler",
                principalColumn: "Id");
        }
    }
}
