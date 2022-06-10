using Microsoft.EntityFrameworkCore.Migrations;

namespace BP.Migrations
{
    public partial class change : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "SportTypes",
                newName: "SportName");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "FieldTypes",
                newName: "FieldName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SportName",
                table: "SportTypes",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "FieldName",
                table: "FieldTypes",
                newName: "Name");
        }
    }
}
