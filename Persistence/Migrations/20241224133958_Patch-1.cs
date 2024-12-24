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
                name: "FK_Gorevler_Departmanlar_Departman_Id",
                table: "Gorevler");

            migrationBuilder.DropForeignKey(
                name: "FK_Kullanicilar_Departmanlar_Departman_Id",
                table: "Kullanicilar");

            migrationBuilder.DropForeignKey(
                name: "FK_Kullanicilar_Gorevler_Gorev_Id",
                table: "Kullanicilar");

            migrationBuilder.DropForeignKey(
                name: "FK_Menuler_Moduller_Modul_Id",
                table: "Menuler");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Kullanicilar",
                table: "Kullanicilar");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Gorevler",
                table: "Gorevler");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Departmanlar",
                table: "Departmanlar");

            migrationBuilder.RenameTable(
                name: "Kullanicilar",
                newName: "ANA_Kullanicilar");

            migrationBuilder.RenameTable(
                name: "Gorevler",
                newName: "ANA_Gorevler");

            migrationBuilder.RenameTable(
                name: "Departmanlar",
                newName: "ANA_Departmanlar");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "Moduller",
                newName: "UpdatedUser");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "Menuler",
                newName: "UpdatedUser");

            migrationBuilder.RenameColumn(
                name: "Modul_Id",
                table: "Menuler",
                newName: "ModulId");

            migrationBuilder.RenameColumn(
                name: "Master_Id",
                table: "Menuler",
                newName: "MasterId");

            migrationBuilder.RenameColumn(
                name: "Detail_Id",
                table: "Menuler",
                newName: "DetailId");

            migrationBuilder.RenameColumn(
                name: "Child_Id",
                table: "Menuler",
                newName: "ChildId");

            migrationBuilder.RenameIndex(
                name: "IX_Menuler_Modul_Id",
                table: "Menuler",
                newName: "IX_Menuler_ModulId");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "ANA_Kullanicilar",
                newName: "UpdatedUser");

            migrationBuilder.RenameColumn(
                name: "Gorev_Id",
                table: "ANA_Kullanicilar",
                newName: "GorevId");

            migrationBuilder.RenameColumn(
                name: "Departman_Id",
                table: "ANA_Kullanicilar",
                newName: "DepartmanId");

            migrationBuilder.RenameIndex(
                name: "IX_Kullanicilar_Gorev_Id",
                table: "ANA_Kullanicilar",
                newName: "IX_ANA_Kullanicilar_GorevId");

            migrationBuilder.RenameIndex(
                name: "IX_Kullanicilar_Departman_Id",
                table: "ANA_Kullanicilar",
                newName: "IX_ANA_Kullanicilar_DepartmanId");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "ANA_Gorevler",
                newName: "UpdatedUser");

            migrationBuilder.RenameColumn(
                name: "Departman_Id",
                table: "ANA_Gorevler",
                newName: "DepartmanId");

            migrationBuilder.RenameIndex(
                name: "IX_Gorevler_Departman_Id",
                table: "ANA_Gorevler",
                newName: "IX_ANA_Gorevler_DepartmanId");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "ANA_Departmanlar",
                newName: "UpdatedUser");

            migrationBuilder.AddColumn<string>(
                name: "CreatedUser",
                table: "Moduller",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedUser",
                table: "Menuler",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Tel",
                table: "ANA_Kullanicilar",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TC",
                table: "ANA_Kullanicilar",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Soyad",
                table: "ANA_Kullanicilar",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Mail",
                table: "ANA_Kullanicilar",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "KullaniciAdi",
                table: "ANA_Kullanicilar",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Gorev",
                table: "ANA_Kullanicilar",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Ad",
                table: "ANA_Kullanicilar",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedUser",
                table: "ANA_Kullanicilar",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Adi",
                table: "ANA_Gorevler",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Acıklama",
                table: "ANA_Gorevler",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedUser",
                table: "ANA_Gorevler",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Kod",
                table: "ANA_Departmanlar",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Adi",
                table: "ANA_Departmanlar",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Acıklama",
                table: "ANA_Departmanlar",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedUser",
                table: "ANA_Departmanlar",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ANA_Kullanicilar",
                table: "ANA_Kullanicilar",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ANA_Gorevler",
                table: "ANA_Gorevler",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ANA_Departmanlar",
                table: "ANA_Departmanlar",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ANA_Gorevler_ANA_Departmanlar_DepartmanId",
                table: "ANA_Gorevler",
                column: "DepartmanId",
                principalTable: "ANA_Departmanlar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ANA_Kullanicilar_ANA_Departmanlar_DepartmanId",
                table: "ANA_Kullanicilar",
                column: "DepartmanId",
                principalTable: "ANA_Departmanlar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ANA_Kullanicilar_ANA_Gorevler_GorevId",
                table: "ANA_Kullanicilar",
                column: "GorevId",
                principalTable: "ANA_Gorevler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Menuler_Moduller_ModulId",
                table: "Menuler",
                column: "ModulId",
                principalTable: "Moduller",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ANA_Gorevler_ANA_Departmanlar_DepartmanId",
                table: "ANA_Gorevler");

            migrationBuilder.DropForeignKey(
                name: "FK_ANA_Kullanicilar_ANA_Departmanlar_DepartmanId",
                table: "ANA_Kullanicilar");

            migrationBuilder.DropForeignKey(
                name: "FK_ANA_Kullanicilar_ANA_Gorevler_GorevId",
                table: "ANA_Kullanicilar");

            migrationBuilder.DropForeignKey(
                name: "FK_Menuler_Moduller_ModulId",
                table: "Menuler");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ANA_Kullanicilar",
                table: "ANA_Kullanicilar");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ANA_Gorevler",
                table: "ANA_Gorevler");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ANA_Departmanlar",
                table: "ANA_Departmanlar");

            migrationBuilder.DropColumn(
                name: "CreatedUser",
                table: "Moduller");

            migrationBuilder.DropColumn(
                name: "CreatedUser",
                table: "Menuler");

            migrationBuilder.DropColumn(
                name: "CreatedUser",
                table: "ANA_Kullanicilar");

            migrationBuilder.DropColumn(
                name: "CreatedUser",
                table: "ANA_Gorevler");

            migrationBuilder.DropColumn(
                name: "CreatedUser",
                table: "ANA_Departmanlar");

            migrationBuilder.RenameTable(
                name: "ANA_Kullanicilar",
                newName: "Kullanicilar");

            migrationBuilder.RenameTable(
                name: "ANA_Gorevler",
                newName: "Gorevler");

            migrationBuilder.RenameTable(
                name: "ANA_Departmanlar",
                newName: "Departmanlar");

            migrationBuilder.RenameColumn(
                name: "UpdatedUser",
                table: "Moduller",
                newName: "UserName");

            migrationBuilder.RenameColumn(
                name: "UpdatedUser",
                table: "Menuler",
                newName: "UserName");

            migrationBuilder.RenameColumn(
                name: "ModulId",
                table: "Menuler",
                newName: "Modul_Id");

            migrationBuilder.RenameColumn(
                name: "MasterId",
                table: "Menuler",
                newName: "Master_Id");

            migrationBuilder.RenameColumn(
                name: "DetailId",
                table: "Menuler",
                newName: "Detail_Id");

            migrationBuilder.RenameColumn(
                name: "ChildId",
                table: "Menuler",
                newName: "Child_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Menuler_ModulId",
                table: "Menuler",
                newName: "IX_Menuler_Modul_Id");

            migrationBuilder.RenameColumn(
                name: "UpdatedUser",
                table: "Kullanicilar",
                newName: "UserName");

            migrationBuilder.RenameColumn(
                name: "GorevId",
                table: "Kullanicilar",
                newName: "Gorev_Id");

            migrationBuilder.RenameColumn(
                name: "DepartmanId",
                table: "Kullanicilar",
                newName: "Departman_Id");

            migrationBuilder.RenameIndex(
                name: "IX_ANA_Kullanicilar_GorevId",
                table: "Kullanicilar",
                newName: "IX_Kullanicilar_Gorev_Id");

            migrationBuilder.RenameIndex(
                name: "IX_ANA_Kullanicilar_DepartmanId",
                table: "Kullanicilar",
                newName: "IX_Kullanicilar_Departman_Id");

            migrationBuilder.RenameColumn(
                name: "UpdatedUser",
                table: "Gorevler",
                newName: "UserName");

            migrationBuilder.RenameColumn(
                name: "DepartmanId",
                table: "Gorevler",
                newName: "Departman_Id");

            migrationBuilder.RenameIndex(
                name: "IX_ANA_Gorevler_DepartmanId",
                table: "Gorevler",
                newName: "IX_Gorevler_Departman_Id");

            migrationBuilder.RenameColumn(
                name: "UpdatedUser",
                table: "Departmanlar",
                newName: "UserName");

            migrationBuilder.AlterColumn<string>(
                name: "Tel",
                table: "Kullanicilar",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TC",
                table: "Kullanicilar",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Soyad",
                table: "Kullanicilar",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Mail",
                table: "Kullanicilar",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "KullaniciAdi",
                table: "Kullanicilar",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Gorev",
                table: "Kullanicilar",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Ad",
                table: "Kullanicilar",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Adi",
                table: "Gorevler",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Acıklama",
                table: "Gorevler",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Kod",
                table: "Departmanlar",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Adi",
                table: "Departmanlar",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Acıklama",
                table: "Departmanlar",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Kullanicilar",
                table: "Kullanicilar",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Gorevler",
                table: "Gorevler",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Departmanlar",
                table: "Departmanlar",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Gorevler_Departmanlar_Departman_Id",
                table: "Gorevler",
                column: "Departman_Id",
                principalTable: "Departmanlar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Kullanicilar_Departmanlar_Departman_Id",
                table: "Kullanicilar",
                column: "Departman_Id",
                principalTable: "Departmanlar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Kullanicilar_Gorevler_Gorev_Id",
                table: "Kullanicilar",
                column: "Gorev_Id",
                principalTable: "Gorevler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Menuler_Moduller_Modul_Id",
                table: "Menuler",
                column: "Modul_Id",
                principalTable: "Moduller",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
