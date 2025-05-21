using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogUygulaması.Migrations
{
    /// <inheritdoc />
    public partial class FirstDataUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WordModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Resim = table.Column<string>(type: "TEXT", nullable: false),
                    AnaBaşlık = table.Column<string>(type: "TEXT", nullable: false),
                    Açıklama = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WordModels", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WordModels");
        }
    }
}
