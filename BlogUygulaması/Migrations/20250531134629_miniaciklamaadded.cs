using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogUygulaması.Migrations
{
    /// <inheritdoc />
    public partial class miniaciklamaadded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MiniAciklama",
                table: "WordModels",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "WordModels",
                keyColumn: "Id",
                keyValue: 1,
                column: "MiniAciklama",
                value: "Kısa açıklama burada");

            migrationBuilder.UpdateData(
                table: "WordModels",
                keyColumn: "Id",
                keyValue: 2,
                column: "MiniAciklama",
                value: "Kısa açıklama burada");

            migrationBuilder.UpdateData(
                table: "WordModels",
                keyColumn: "Id",
                keyValue: 3,
                column: "MiniAciklama",
                value: "Kısa açıklama burada");

            migrationBuilder.UpdateData(
                table: "WordModels",
                keyColumn: "Id",
                keyValue: 4,
                column: "MiniAciklama",
                value: "Kısa açıklama burada");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MiniAciklama",
                table: "WordModels");
        }
    }
}
