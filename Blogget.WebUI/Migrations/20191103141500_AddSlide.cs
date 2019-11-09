using Microsoft.EntityFrameworkCore.Migrations;

namespace Blogget.WebUI.Migrations
{
    public partial class AddSlide : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsSlide",
                table: "Blogs",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsSlide",
                table: "Blogs");
        }
    }
}
