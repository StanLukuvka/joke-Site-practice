using Microsoft.EntityFrameworkCore.Migrations;

namespace joke_Site_practice.Data.Migrations
{
    public partial class what : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "JokeEmail",
                table: "Joke",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "JokeEmail",
                table: "Joke");
        }
    }
}
