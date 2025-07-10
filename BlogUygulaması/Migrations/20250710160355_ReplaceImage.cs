using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogUygulaması.Migrations
{
    /// <inheritdoc />
    public partial class ReplaceImage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "KonularModel",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.UpdateData(
                table: "KonularModel",
                keyColumn: "Id",
                keyValue: 2,
                column: "Resim",
                value: "/img/category/hangi_programlama_dili-740x555.jpg");

            migrationBuilder.UpdateData(
                table: "KonularModel",
                keyColumn: "Id",
                keyValue: 3,
                column: "Resim",
                value: "/img/category/indir.jpg");

            migrationBuilder.UpdateData(
                table: "KonularModel",
                keyColumn: "Id",
                keyValue: 4,
                column: "Resim",
                value: "/img/category/gunluk.jpg");

            migrationBuilder.UpdateData(
                table: "KonularModel",
                keyColumn: "Id",
                keyValue: 5,
                column: "Resim",
                value: "/img/category/egitim.jpg");

            migrationBuilder.UpdateData(
                table: "KonularModel",
                keyColumn: "Id",
                keyValue: 6,
                column: "Resim",
                value: "/img/category/seyahet.jpg");

            migrationBuilder.UpdateData(
                table: "KonularModel",
                keyColumn: "Id",
                keyValue: 7,
                column: "Resim",
                value: "/img/category/saglık.jpg");

            migrationBuilder.UpdateData(
                table: "KonularModel",
                keyColumn: "Id",
                keyValue: 8,
                column: "Resim",
                value: "/img/category/inceleme.jpg");

            migrationBuilder.UpdateData(
                table: "KonularModel",
                keyColumn: "Id",
                keyValue: 9,
                column: "Resim",
                value: "/img/category/girisimcilik.jpg");

            migrationBuilder.UpdateData(
                table: "KonularModel",
                keyColumn: "Id",
                keyValue: 10,
                column: "Resim",
                value: "/img/category/Bilim.jpg");

            migrationBuilder.UpdateData(
                table: "KonularModel",
                keyColumn: "Id",
                keyValue: 11,
                column: "Resim",
                value: "/img/category/fotografcılık.jpg");

            migrationBuilder.UpdateData(
                table: "KonularModel",
                keyColumn: "Id",
                keyValue: 12,
                column: "Resim",
                value: "/img/category/Finans.jpg");

            migrationBuilder.UpdateData(
                table: "KonularModel",
                keyColumn: "Id",
                keyValue: 13,
                column: "Resim",
                value: "/img/category/Moda.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "KonularModel",
                keyColumn: "Id",
                keyValue: 2,
                column: "Resim",
                value: "/img/category/finans-yonetimi.png");

            migrationBuilder.UpdateData(
                table: "KonularModel",
                keyColumn: "Id",
                keyValue: 3,
                column: "Resim",
                value: "/img/category/finans-yonetimi.png");

            migrationBuilder.UpdateData(
                table: "KonularModel",
                keyColumn: "Id",
                keyValue: 4,
                column: "Resim",
                value: "/img/category/finans-yonetimi.png");

            migrationBuilder.UpdateData(
                table: "KonularModel",
                keyColumn: "Id",
                keyValue: 5,
                column: "Resim",
                value: "/img/category/finans-yonetimi.png");

            migrationBuilder.UpdateData(
                table: "KonularModel",
                keyColumn: "Id",
                keyValue: 6,
                column: "Resim",
                value: "/img/category/finans-yonetimi.png");

            migrationBuilder.UpdateData(
                table: "KonularModel",
                keyColumn: "Id",
                keyValue: 7,
                column: "Resim",
                value: "/img/category/finans-yonetimi.png");

            migrationBuilder.UpdateData(
                table: "KonularModel",
                keyColumn: "Id",
                keyValue: 8,
                column: "Resim",
                value: "/img/category/finans-yonetimi.png");

            migrationBuilder.UpdateData(
                table: "KonularModel",
                keyColumn: "Id",
                keyValue: 9,
                column: "Resim",
                value: "/img/category/finans-yonetimi.png");

            migrationBuilder.UpdateData(
                table: "KonularModel",
                keyColumn: "Id",
                keyValue: 10,
                column: "Resim",
                value: "/img/category/finans-yonetimi.png");

            migrationBuilder.UpdateData(
                table: "KonularModel",
                keyColumn: "Id",
                keyValue: 11,
                column: "Resim",
                value: "/img/category/finans-yonetimi.png");

            migrationBuilder.UpdateData(
                table: "KonularModel",
                keyColumn: "Id",
                keyValue: 12,
                column: "Resim",
                value: "/img/category/finans-yonetimi.png");

            migrationBuilder.UpdateData(
                table: "KonularModel",
                keyColumn: "Id",
                keyValue: 13,
                column: "Resim",
                value: "/img/category/finans-yonetimi.png");

            migrationBuilder.InsertData(
                table: "KonularModel",
                columns: new[] { "Id", "Konu", "Resim" },
                values: new object[] { 14, "Yemek Tarifleri", "/img/category/finans-yonetimi.png" });
        }
    }
}
