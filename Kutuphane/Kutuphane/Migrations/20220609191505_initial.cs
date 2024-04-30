using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kutuphane.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kitaplar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    barkodno = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    kitapadi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    yazari = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    yayinevi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sayfasayisi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    turu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    stoksayisi = table.Column<int>(type: "int", nullable: false),
                    rafno = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    kayittarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kitaplar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Uyeler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    adsoyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    yas = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cinsiyet = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    telefon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    adres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uyeler", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kitaplar");

            migrationBuilder.DropTable(
                name: "Uyeler");
        }
    }
}
