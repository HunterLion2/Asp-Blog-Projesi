using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogUygulaması.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Resim",
                table: "WordModels");

            migrationBuilder.AddColumn<string>(
                name: "ResimDosyaAdi",
                table: "WordModels",
                type: "TEXT",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "WordModels",
                keyColumn: "Id",
                keyValue: 1,
                column: "ResimDosyaAdi",
                value: "resim.jpg");

            migrationBuilder.UpdateData(
                table: "WordModels",
                keyColumn: "Id",
                keyValue: 2,
                column: "ResimDosyaAdi",
                value: "image.jpg");

            migrationBuilder.UpdateData(
                table: "WordModels",
                keyColumn: "Id",
                keyValue: 3,
                column: "ResimDosyaAdi",
                value: "resim.jpg");

            migrationBuilder.UpdateData(
                table: "WordModels",
                keyColumn: "Id",
                keyValue: 4,
                column: "ResimDosyaAdi",
                value: "resim.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ResimDosyaAdi",
                table: "WordModels");

            migrationBuilder.AddColumn<string>(
                name: "Resim",
                table: "WordModels",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "WordModels",
                keyColumn: "Id",
                keyValue: 1,
                column: "Resim",
                value: "resim.jpg");

            migrationBuilder.UpdateData(
                table: "WordModels",
                keyColumn: "Id",
                keyValue: 2,
                column: "Resim",
                value: "image.jpg");

            migrationBuilder.UpdateData(
                table: "WordModels",
                keyColumn: "Id",
                keyValue: 3,
                column: "Resim",
                value: "resim.jpg");

            migrationBuilder.UpdateData(
                table: "WordModels",
                keyColumn: "Id",
                keyValue: 4,
                column: "Resim",
                value: "resim.jpg");
        }
    }
}
