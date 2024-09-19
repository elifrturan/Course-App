using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class ogretmenTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kurslar_Ogretmen_OgretmenID",
                table: "Kurslar");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ogretmen",
                table: "Ogretmen");

            migrationBuilder.RenameTable(
                name: "Ogretmen",
                newName: "Ogretmenler");

            migrationBuilder.AlterColumn<int>(
                name: "OgretmenID",
                table: "Kurslar",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ogretmenler",
                table: "Ogretmenler",
                column: "OgretmenID");

            migrationBuilder.AddForeignKey(
                name: "FK_Kurslar_Ogretmenler_OgretmenID",
                table: "Kurslar",
                column: "OgretmenID",
                principalTable: "Ogretmenler",
                principalColumn: "OgretmenID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kurslar_Ogretmenler_OgretmenID",
                table: "Kurslar");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ogretmenler",
                table: "Ogretmenler");

            migrationBuilder.RenameTable(
                name: "Ogretmenler",
                newName: "Ogretmen");

            migrationBuilder.AlterColumn<int>(
                name: "OgretmenID",
                table: "Kurslar",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ogretmen",
                table: "Ogretmen",
                column: "OgretmenID");

            migrationBuilder.AddForeignKey(
                name: "FK_Kurslar_Ogretmen_OgretmenID",
                table: "Kurslar",
                column: "OgretmenID",
                principalTable: "Ogretmen",
                principalColumn: "OgretmenID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
