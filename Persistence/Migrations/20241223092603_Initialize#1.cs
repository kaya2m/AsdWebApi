using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Initialize1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Birimlers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Acıklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Birimlers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Gorevlers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Acıklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gorevlers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Gruplars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Acıklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gruplars", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OnYuz_Yetkiler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kullanici_GrupId = table.Column<int>(type: "int", nullable: false),
                    Modul_Id = table.Column<int>(type: "int", nullable: false),
                    View_Id = table.Column<int>(type: "int", nullable: false),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OnYuz_Yetkiler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kullanicilars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KullaniciAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gorev = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sifre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SifreHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProfilResmi = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Grup_Id = table.Column<int>(type: "int", nullable: false),
                    Birim_Id = table.Column<int>(type: "int", nullable: false),
                    Gorev_Id = table.Column<int>(type: "int", nullable: false),
                    GruplarId = table.Column<int>(type: "int", nullable: true),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanicilars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Kullanicilars_Birimlers_Birim_Id",
                        column: x => x.Birim_Id,
                        principalTable: "Birimlers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Kullanicilars_Gorevlers_Gorev_Id",
                        column: x => x.Gorev_Id,
                        principalTable: "Gorevlers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Kullanicilars_Gruplars_GruplarId",
                        column: x => x.GruplarId,
                        principalTable: "Gruplars",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Modullers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModulAd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModulRenk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModulIkon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Acıklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModulURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YetkilerId = table.Column<int>(type: "int", nullable: true),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modullers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Modullers_OnYuz_Yetkiler_YetkilerId",
                        column: x => x.YetkilerId,
                        principalTable: "OnYuz_Yetkiler",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Menulers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MenuIkon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ControllerAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ViewAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Modul_Id = table.Column<int>(type: "int", nullable: false),
                    Master_Id = table.Column<int>(type: "int", nullable: false),
                    Detail_Id = table.Column<int>(type: "int", nullable: false),
                    Child_Id = table.Column<int>(type: "int", nullable: false),
                    SiraNo = table.Column<int>(type: "int", nullable: false),
                    YetkilerId = table.Column<int>(type: "int", nullable: true),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menulers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Menulers_Modullers_Modul_Id",
                        column: x => x.Modul_Id,
                        principalTable: "Modullers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Menulers_OnYuz_Yetkiler_YetkilerId",
                        column: x => x.YetkilerId,
                        principalTable: "OnYuz_Yetkiler",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Kullanicilars_Birim_Id",
                table: "Kullanicilars",
                column: "Birim_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Kullanicilars_Gorev_Id",
                table: "Kullanicilars",
                column: "Gorev_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Kullanicilars_GruplarId",
                table: "Kullanicilars",
                column: "GruplarId");

            migrationBuilder.CreateIndex(
                name: "IX_Menulers_Modul_Id",
                table: "Menulers",
                column: "Modul_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Menulers_YetkilerId",
                table: "Menulers",
                column: "YetkilerId");

            migrationBuilder.CreateIndex(
                name: "IX_Modullers_YetkilerId",
                table: "Modullers",
                column: "YetkilerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kullanicilars");

            migrationBuilder.DropTable(
                name: "Menulers");

            migrationBuilder.DropTable(
                name: "Birimlers");

            migrationBuilder.DropTable(
                name: "Gorevlers");

            migrationBuilder.DropTable(
                name: "Gruplars");

            migrationBuilder.DropTable(
                name: "Modullers");

            migrationBuilder.DropTable(
                name: "OnYuz_Yetkiler");
        }
    }
}
