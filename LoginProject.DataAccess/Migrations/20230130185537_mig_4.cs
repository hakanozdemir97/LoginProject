using Microsoft.EntityFrameworkCore.Migrations;

namespace LoginProject.DataAccess.Migrations
{
    public partial class mig_4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "Imdb",
                table: "Movies",
                type: "real",
                nullable: false,
                defaultValue: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Imdb",
                table: "Movies");
        }
    }
}
