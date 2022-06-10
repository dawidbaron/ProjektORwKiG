using Microsoft.EntityFrameworkCore.Migrations;

namespace BP.Migrations
{
    public partial class Proprename : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Fields",
                newName: "Name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Fields",
                newName: "Title");
        }
    }
}
