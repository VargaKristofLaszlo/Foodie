using Microsoft.EntityFrameworkCore.Migrations;

namespace Foodie.Dal.Migrations
{
    public partial class Addedcommenttotherating : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Comment",
                table: "Rating",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Comment",
                table: "Rating");
        }
    }
}
