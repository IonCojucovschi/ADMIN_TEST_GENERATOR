using Microsoft.EntityFrameworkCore.Migrations;

namespace PddAdmin.Migrations
{
    public partial class add_new_property : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ChapterKey",
                table: "QueryItem",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ChapterKey",
                table: "QueryItem");
        }
    }
}
