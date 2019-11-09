using Microsoft.EntityFrameworkCore.Migrations;

namespace Blogget.WebUI.Migrations
{
    public partial class HtmlCreared : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BlogHtml",
                table: "Blogs",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BlogHtml",
                table: "Blogs");
        }
    }
}
