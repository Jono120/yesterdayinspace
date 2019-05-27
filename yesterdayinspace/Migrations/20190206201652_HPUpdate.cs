using Microsoft.EntityFrameworkCore.Migrations;

namespace yesterdayinspace.Migrations
{
    public partial class HPUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Caption",
                table: "HPContent",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Social",
                table: "HPContent",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Thumb",
                table: "HPContent",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Caption",
                table: "HPContent");

            migrationBuilder.DropColumn(
                name: "Social",
                table: "HPContent");

            migrationBuilder.DropColumn(
                name: "Thumb",
                table: "HPContent");
        }
    }
}
