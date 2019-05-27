using Microsoft.EntityFrameworkCore.Migrations;

namespace yesterdayinspace.Migrations
{
    public partial class SocialLinks2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Social1Display",
                table: "CCEntity",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Social1Type",
                table: "CCEntity",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Social1URL",
                table: "CCEntity",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Social2Display",
                table: "CCEntity",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Social2Type",
                table: "CCEntity",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Social2URL",
                table: "CCEntity",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Social3Display",
                table: "CCEntity",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Social3Type",
                table: "CCEntity",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Social3URL",
                table: "CCEntity",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Social4Display",
                table: "CCEntity",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Social4Type",
                table: "CCEntity",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Social4URL",
                table: "CCEntity",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Social5Display",
                table: "CCEntity",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Social5Type",
                table: "CCEntity",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Social5URL",
                table: "CCEntity",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Social1Display",
                table: "CCEntity");

            migrationBuilder.DropColumn(
                name: "Social1Type",
                table: "CCEntity");

            migrationBuilder.DropColumn(
                name: "Social1URL",
                table: "CCEntity");

            migrationBuilder.DropColumn(
                name: "Social2Display",
                table: "CCEntity");

            migrationBuilder.DropColumn(
                name: "Social2Type",
                table: "CCEntity");

            migrationBuilder.DropColumn(
                name: "Social2URL",
                table: "CCEntity");

            migrationBuilder.DropColumn(
                name: "Social3Display",
                table: "CCEntity");

            migrationBuilder.DropColumn(
                name: "Social3Type",
                table: "CCEntity");

            migrationBuilder.DropColumn(
                name: "Social3URL",
                table: "CCEntity");

            migrationBuilder.DropColumn(
                name: "Social4Display",
                table: "CCEntity");

            migrationBuilder.DropColumn(
                name: "Social4Type",
                table: "CCEntity");

            migrationBuilder.DropColumn(
                name: "Social4URL",
                table: "CCEntity");

            migrationBuilder.DropColumn(
                name: "Social5Display",
                table: "CCEntity");

            migrationBuilder.DropColumn(
                name: "Social5Type",
                table: "CCEntity");

            migrationBuilder.DropColumn(
                name: "Social5URL",
                table: "CCEntity");
        }
    }
}
