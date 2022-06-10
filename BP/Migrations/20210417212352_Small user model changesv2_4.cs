using Microsoft.EntityFrameworkCore.Migrations;

namespace BP.Migrations
{
    public partial class Smallusermodelchangesv2_4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Email",
                table: "User",
                newName: "EmailAddress");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EmailAddress",
                table: "User",
                newName: "Email");
        }
    }
}
