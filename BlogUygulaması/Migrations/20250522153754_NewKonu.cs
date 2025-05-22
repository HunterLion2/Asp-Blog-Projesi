using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlogUygulaması.Migrations
{
    /// <inheritdoc />
    public partial class NewKonu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KonularModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Konu = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KonularModel", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "KonularModel",
                columns: new[] { "Id", "Konu" },
                values: new object[,]
                {
                    { 1, "Finans" },
                    { 2, "Doğa" },
                    { 3, "Güncel" }
                });

            migrationBuilder.InsertData(
                table: "WordModels",
                columns: new[] { "Id", "AnaBaşlık", "Açıklama", "DateTime", "Konu", "Resim" },
                values: new object[,]
                {
                    { 2, "Doğanın Sorunları", "Lorem ipsum dolor sit, amet consectetur adipisicing elit. Obcaecati praesentium ducimus tenetur impedit qui, dignissimos ea, omnis quisquam deleniti veniam laudantium, exercitationem voluptatem sit commodi. Minima aperiam voluptates, quasi a cumque dolorem, eum repellat rem dicta neque pariatur. Maiores fugiat doloremque placeat, voluptatum nobis repudiandae dolores consequatur dicta ratione non.", new DateTime(2025, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doğa", "image.jpg" },
                    { 3, "İntel Ve Amd Arasındaki Savaş", "Lorem ipsum dolor sit, amet consectetur adipisicing elit. Obcaecati praesentium ducimus tenetur impedit qui, dignissimos ea, omnis quisquam deleniti veniam laudantium, exercitationem voluptatem sit commodi. Minima aperiam voluptates, quasi a cumque dolorem, eum repellat rem dicta neque pariatur. Maiores fugiat doloremque placeat, voluptatum nobis repudiandae dolores consequatur dicta ratione non.", new DateTime(2025, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finans", "resim.jpg" },
                    { 4, "Trafik Cezalarındaki Artış", "Lorem ipsum dolor sit, amet consectetur adipisicing elit. Obcaecati praesentium ducimus tenetur impedit qui, dignissimos ea, omnis quisquam deleniti veniam laudantium, exercitationem voluptatem sit commodi. Minima aperiam voluptates, quasi a cumque dolorem, eum repellat rem dicta neque pariatur. Maiores fugiat doloremque placeat, voluptatum nobis repudiandae dolores consequatur dicta ratione non.", new DateTime(2025, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Güncel", "resim.jpg" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KonularModel");

            migrationBuilder.DeleteData(
                table: "WordModels",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "WordModels",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "WordModels",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
