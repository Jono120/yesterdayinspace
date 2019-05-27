using Microsoft.EntityFrameworkCore.Migrations;

namespace yesterdayinspace.Migrations
{
    public partial class StructureUpgrade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "APContent",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Content = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_APContent", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "GPContent",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Type = table.Column<string>(nullable: true),
                    ThumbURL = table.Column<string>(nullable: true),
                    URL = table.Column<string>(nullable: true),
                    Caption = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GPContent", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "HPContent",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Section = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    URL = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HPContent", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "APContent");

            migrationBuilder.DropTable(
                name: "GPContent");

            migrationBuilder.DropTable(
                name: "HPContent");
        }
    }
}
