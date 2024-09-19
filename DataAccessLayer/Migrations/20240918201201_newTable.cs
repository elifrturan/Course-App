using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class newTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OgretmenID",
                table: "Kurslar",
                type: "int",
                nullable: true,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Ogretmen",
                columns: table => new
                {
                    OgretmenID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OgretmenAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OgretmenSoyadi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Eposta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BaslamaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ogretmen", x => x.OgretmenID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Kurslar_OgretmenID",
                table: "Kurslar",
                column: "OgretmenID");

            migrationBuilder.AddForeignKey(
                name: "FK_Kurslar_Ogretmen_OgretmenID",
                table: "Kurslar",
                column: "OgretmenID",
                principalTable: "Ogretmen",
                principalColumn: "OgretmenID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kurslar_Ogretmen_OgretmenID",
                table: "Kurslar");

            migrationBuilder.DropTable(
                name: "Ogretmen");

            migrationBuilder.DropIndex(
                name: "IX_Kurslar_OgretmenID",
                table: "Kurslar");

            migrationBuilder.DropColumn(
                name: "OgretmenID",
                table: "Kurslar");
        }
    }
}
