using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorCRUDSSR.Migrations
{
    /// <inheritdoc />
    public partial class twotime : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirthYear = table.Column<int>(type: "int", nullable: true),
                    FavoriteGameId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Persons_VideoGames_FavoriteGameId",
                        column: x => x.FavoriteGameId,
                        principalTable: "VideoGames",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "BirthYear", "City", "FavoriteGameId", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, 1974, "Ljusne", null, "Lars", "Asplund" },
                    { 2, 1964, "Sandarne", null, "Nisse", "Manpower" },
                    { 3, 1988, "Vallvik", null, "Frida", "Edvinsson" }
                });

            migrationBuilder.UpdateData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 2,
                column: "Publisher",
                value: "X-Corp");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_FavoriteGameId",
                table: "Persons",
                column: "FavoriteGameId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Persons");

            migrationBuilder.UpdateData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 2,
                column: "Publisher",
                value: "XXXXXXRE");
        }
    }
}
