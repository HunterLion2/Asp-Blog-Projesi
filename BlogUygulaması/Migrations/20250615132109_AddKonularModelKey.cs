using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlogUygulaması.Migrations
{
    /// <inheritdoc />
    public partial class AddKonularModelKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "KonularModel",
                keyColumn: "Id",
                keyValue: 2,
                column: "Konu",
                value: "Yazılım / Programlama");

            migrationBuilder.UpdateData(
                table: "KonularModel",
                keyColumn: "Id",
                keyValue: 3,
                column: "Konu",
                value: "Kişisel Gelişim");

            migrationBuilder.InsertData(
                table: "KonularModel",
                columns: new[] { "Id", "Konu" },
                values: new object[,]
                {
                    { 4, "Günlük Yaşam" },
                    { 5, "Eğitim" },
                    { 6, "Seyahat" },
                    { 7, "Sağlık & Fitness" },
                    { 8, "Kitap / Film / Dizi İncelemeleri" },
                    { 9, "Girişimcilik" },
                    { 10, "Bilim" },
                    { 11, "Fotoğrafçılık" },
                    { 12, "Finans / Ekonomi" },
                    { 13, "Moda & Stil" },
                    { 14, "Yemek Tarifleri" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "KonularModel",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "KonularModel",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "KonularModel",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "KonularModel",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "KonularModel",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "KonularModel",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "KonularModel",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "KonularModel",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "KonularModel",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "KonularModel",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "KonularModel",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.UpdateData(
                table: "KonularModel",
                keyColumn: "Id",
                keyValue: 2,
                column: "Konu",
                value: "Doğa");

            migrationBuilder.UpdateData(
                table: "KonularModel",
                keyColumn: "Id",
                keyValue: 3,
                column: "Konu",
                value: "Güncel");
        }
    }
}
