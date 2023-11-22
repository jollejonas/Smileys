using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Smileys.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CVR = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CurrentSmileyUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PreviousSmiley1Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PreviousSmiley2Urls = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PreviousSmiley3Urls = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Company_CVR",
                table: "Company",
                column: "CVR",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Company");
        }
    }
}
