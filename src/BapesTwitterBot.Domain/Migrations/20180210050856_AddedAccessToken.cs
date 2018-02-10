using Microsoft.EntityFrameworkCore.Migrations;

namespace BapesTwitterBot.Domain.Migrations
{
    public partial class AddedAccessToken : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                "Pin",
                "TwitterUsers");

            migrationBuilder.AddColumn<string>(
                "AccessToken",
                "TwitterUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                "AccessTokenSecret",
                "TwitterUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                "AccessToken",
                "TwitterUsers");

            migrationBuilder.DropColumn(
                "AccessTokenSecret",
                "TwitterUsers");

            migrationBuilder.AddColumn<int>(
                "Pin",
                "TwitterUsers",
                nullable: false,
                defaultValue: 0);
        }
    }
}