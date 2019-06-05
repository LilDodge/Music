using Microsoft.EntityFrameworkCore.Migrations;

namespace Music.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Singer = table.Column<string>(maxLength: 30, nullable: false),
                    City = table.Column<string>(nullable: true),
                    Song = table.Column<string>(nullable: true),
                    Style = table.Column<string>(nullable: true),
                    PictureUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Singer);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Teams");
        }
    }
}
