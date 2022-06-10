using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BP.Migrations
{
    public partial class ChangingFieldModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "FieldContactId1",
                table: "Fields",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "FieldTypeId1",
                table: "Fields",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "SportTypeId1",
                table: "Fields",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_FieldId",
                table: "Reservations",
                column: "FieldId");

            migrationBuilder.CreateIndex(
                name: "IX_Fields_FieldContactId1",
                table: "Fields",
                column: "FieldContactId1");

            migrationBuilder.CreateIndex(
                name: "IX_Fields_FieldTypeId1",
                table: "Fields",
                column: "FieldTypeId1");

            migrationBuilder.CreateIndex(
                name: "IX_Fields_SportTypeId1",
                table: "Fields",
                column: "SportTypeId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Fields_FieldContacts_FieldContactId1",
                table: "Fields",
                column: "FieldContactId1",
                principalTable: "FieldContacts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Fields_FieldTypes_FieldTypeId1",
                table: "Fields",
                column: "FieldTypeId1",
                principalTable: "FieldTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Fields_SportTypes_SportTypeId1",
                table: "Fields",
                column: "SportTypeId1",
                principalTable: "SportTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Fields_FieldId",
                table: "Reservations",
                column: "FieldId",
                principalTable: "Fields",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fields_FieldContacts_FieldContactId1",
                table: "Fields");

            migrationBuilder.DropForeignKey(
                name: "FK_Fields_FieldTypes_FieldTypeId1",
                table: "Fields");

            migrationBuilder.DropForeignKey(
                name: "FK_Fields_SportTypes_SportTypeId1",
                table: "Fields");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Fields_FieldId",
                table: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_FieldId",
                table: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Fields_FieldContactId1",
                table: "Fields");

            migrationBuilder.DropIndex(
                name: "IX_Fields_FieldTypeId1",
                table: "Fields");

            migrationBuilder.DropIndex(
                name: "IX_Fields_SportTypeId1",
                table: "Fields");

            migrationBuilder.DropColumn(
                name: "FieldContactId1",
                table: "Fields");

            migrationBuilder.DropColumn(
                name: "FieldTypeId1",
                table: "Fields");

            migrationBuilder.DropColumn(
                name: "SportTypeId1",
                table: "Fields");
        }
    }
}
