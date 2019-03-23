using Microsoft.EntityFrameworkCore.Migrations;

namespace DatingApp.APi.Migrations
{
    public partial class addAdress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "value",
                table: "Values");

            migrationBuilder.AddColumn<string>(
                name: "adress",
                table: "Values",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "adress",
                table: "Values");

            migrationBuilder.AddColumn<int>(
                name: "value",
                table: "Values",
                nullable: false,
                defaultValue: 0);
        }
    }
}
