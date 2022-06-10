using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BP.Migrations
{
    public partial class Changeprop : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Field",
                newName: "FieldName");

            migrationBuilder.AddColumn<Guid>(
                name: "FieldId",
                table: "Payment",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Payment_FieldId",
                table: "Payment",
                column: "FieldId");

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_Field_FieldId",
                table: "Payment",
                column: "FieldId",
                principalTable: "Field",
                principalColumn: "FieldId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payment_Field_FieldId",
                table: "Payment");

            migrationBuilder.DropIndex(
                name: "IX_Payment_FieldId",
                table: "Payment");

            migrationBuilder.DropColumn(
                name: "FieldId",
                table: "Payment");

            migrationBuilder.RenameColumn(
                name: "FieldName",
                table: "Field",
                newName: "Name");
        }
    }
}
