using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogUygulaması.Migrations
{
    /// <inheritdoc />
    public partial class Categoryİmage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Resim",
                table: "KonularModel",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "KonularModel",
                keyColumn: "Id",
                keyValue: 1,
                column: "Resim",
                value: "~/img/category/finansyonetimi.png");

            migrationBuilder.UpdateData(
                table: "KonularModel",
                keyColumn: "Id",
                keyValue: 2,
                column: "Resim",
                value: "~/img/category/finansyonetimi.png");

            migrationBuilder.UpdateData(
                table: "KonularModel",
                keyColumn: "Id",
                keyValue: 3,
                column: "Resim",
                value: "~/img/category/finansyonetimi.png");

            migrationBuilder.UpdateData(
                table: "KonularModel",
                keyColumn: "Id",
                keyValue: 4,
                column: "Resim",
                value: "~/img/category/finansyonetimi.png");

            migrationBuilder.UpdateData(
                table: "KonularModel",
                keyColumn: "Id",
                keyValue: 5,
                column: "Resim",
                value: "~/img/category/finansyonetimi.png");

            migrationBuilder.UpdateData(
                table: "KonularModel",
                keyColumn: "Id",
                keyValue: 6,
                column: "Resim",
                value: "~/img/category/finansyonetimi.png");

            migrationBuilder.UpdateData(
                table: "KonularModel",
                keyColumn: "Id",
                keyValue: 7,
                column: "Resim",
                value: "~/img/category/finansyonetimi.png");

            migrationBuilder.UpdateData(
                table: "KonularModel",
                keyColumn: "Id",
                keyValue: 8,
                column: "Resim",
                value: "~/img/category/finansyonetimi.png");

            migrationBuilder.UpdateData(
                table: "KonularModel",
                keyColumn: "Id",
                keyValue: 9,
                column: "Resim",
                value: "~/img/category/finansyonetimi.png");

            migrationBuilder.UpdateData(
                table: "KonularModel",
                keyColumn: "Id",
                keyValue: 10,
                column: "Resim",
                value: "~/img/category/finansyonetimi.png");

            migrationBuilder.UpdateData(
                table: "KonularModel",
                keyColumn: "Id",
                keyValue: 11,
                column: "Resim",
                value: "~/img/category/finansyonetimi.png");

            migrationBuilder.UpdateData(
                table: "KonularModel",
                keyColumn: "Id",
                keyValue: 12,
                column: "Resim",
                value: "~/img/category/finansyonetimi.png");

            migrationBuilder.UpdateData(
                table: "KonularModel",
                keyColumn: "Id",
                keyValue: 13,
                column: "Resim",
                value: "~/img/category/finansyonetimi.png");

            migrationBuilder.UpdateData(
                table: "KonularModel",
                keyColumn: "Id",
                keyValue: 14,
                column: "Resim",
                value: "~/img/category/finansyonetimi.png");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Resim",
                table: "KonularModel");
        }
    }
}
