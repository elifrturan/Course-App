using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class updateTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_KursKayitlari_KursID",
                table: "KursKayitlari",
                column: "KursID");

            migrationBuilder.CreateIndex(
                name: "IX_KursKayitlari_OgrenciID",
                table: "KursKayitlari",
                column: "OgrenciID");

            migrationBuilder.AddForeignKey(
                name: "FK_KursKayitlari_Kurslar_KursID",
                table: "KursKayitlari",
                column: "KursID",
                principalTable: "Kurslar",
                principalColumn: "KursID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_KursKayitlari_Ogrenciler_OgrenciID",
                table: "KursKayitlari",
                column: "OgrenciID",
                principalTable: "Ogrenciler",
                principalColumn: "OgrenciID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KursKayitlari_Kurslar_KursID",
                table: "KursKayitlari");

            migrationBuilder.DropForeignKey(
                name: "FK_KursKayitlari_Ogrenciler_OgrenciID",
                table: "KursKayitlari");

            migrationBuilder.DropIndex(
                name: "IX_KursKayitlari_KursID",
                table: "KursKayitlari");

            migrationBuilder.DropIndex(
                name: "IX_KursKayitlari_OgrenciID",
                table: "KursKayitlari");
        }
    }
}
