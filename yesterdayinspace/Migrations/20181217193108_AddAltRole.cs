using Microsoft.EntityFrameworkCore.Migrations;

namespace yesterdayinspace.Migrations
{
    public partial class AddAltRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AltRole",
                table: "CCEntity",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AltRole",
                table: "CCEntity");
        }
    }
}
