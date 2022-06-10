using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BP.Migrations
{
    public partial class ChangingFieldModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropPrimaryKey(
                name: "PK_SportTypes",
                table: "SportTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FieldTypes",
                table: "FieldTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Fields",
                table: "Fields");

            migrationBuilder.DropIndex(
                name: "IX_Fields_FieldContactId1",
                table: "Fields");

            migrationBuilder.DropIndex(
                name: "IX_Fields_FieldTypeId1",
                table: "Fields");

            migrationBuilder.DropIndex(
                name: "IX_Fields_SportTypeId1",
                table: "Fields");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FieldContacts",
                table: "FieldContacts");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "SportTypes");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "SportTypes");

            migrationBuilder.DropColumn(
                name: "ModifiedOn",
                table: "SportTypes");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "FieldTypes");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "FieldTypes");

            migrationBuilder.DropColumn(
                name: "ModifiedOn",
                table: "FieldTypes");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Fields");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Fields");

            migrationBuilder.DropColumn(
                name: "FieldContactId",
                table: "Fields");

            migrationBuilder.DropColumn(
                name: "FieldContactId1",
                table: "Fields");

            migrationBuilder.DropColumn(
                name: "FieldTypeId",
                table: "Fields");

            migrationBuilder.DropColumn(
                name: "FieldTypeId1",
                table: "Fields");

            migrationBuilder.DropColumn(
                name: "ModifiedOn",
                table: "Fields");

            migrationBuilder.DropColumn(
                name: "SportTypeId1",
                table: "Fields");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "FieldContacts");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "FieldContacts");

            migrationBuilder.DropColumn(
                name: "ModifiedOn",
                table: "FieldContacts");

            migrationBuilder.RenameTable(
                name: "SportTypes",
                newName: "SsportType");

            migrationBuilder.RenameTable(
                name: "FieldTypes",
                newName: "FieldType");

            migrationBuilder.RenameTable(
                name: "Fields",
                newName: "Field");

            migrationBuilder.RenameTable(
                name: "FieldContacts",
                newName: "FieldContact");

            migrationBuilder.RenameColumn(
                name: "FieldName",
                table: "FieldType",
                newName: "FieldTypeName");

            migrationBuilder.RenameColumn(
                name: "SportTypeId",
                table: "Field",
                newName: "FieldId");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "FieldContact",
                newName: "FieldContactName");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SsportType",
                table: "SsportType",
                column: "FieldId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FieldType",
                table: "FieldType",
                column: "FieldId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Field",
                table: "Field",
                column: "FieldId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FieldContact",
                table: "FieldContact",
                column: "FieldId");

            migrationBuilder.AddForeignKey(
                name: "FK_FieldContact_Field_FieldId",
                table: "FieldContact",
                column: "FieldId",
                principalTable: "Field",
                principalColumn: "FieldId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FieldType_Field_FieldId",
                table: "FieldType",
                column: "FieldId",
                principalTable: "Field",
                principalColumn: "FieldId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Field_FieldId",
                table: "Reservations",
                column: "FieldId",
                principalTable: "Field",
                principalColumn: "FieldId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SsportType_Field_FieldId",
                table: "SsportType",
                column: "FieldId",
                principalTable: "Field",
                principalColumn: "FieldId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FieldContact_Field_FieldId",
                table: "FieldContact");

            migrationBuilder.DropForeignKey(
                name: "FK_FieldType_Field_FieldId",
                table: "FieldType");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Field_FieldId",
                table: "Reservations");

            migrationBuilder.DropForeignKey(
                name: "FK_SsportType_Field_FieldId",
                table: "SsportType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SsportType",
                table: "SsportType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FieldType",
                table: "FieldType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FieldContact",
                table: "FieldContact");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Field",
                table: "Field");

            migrationBuilder.RenameTable(
                name: "SsportType",
                newName: "SportTypes");

            migrationBuilder.RenameTable(
                name: "FieldType",
                newName: "FieldTypes");

            migrationBuilder.RenameTable(
                name: "FieldContact",
                newName: "FieldContacts");

            migrationBuilder.RenameTable(
                name: "Field",
                newName: "Fields");

            migrationBuilder.RenameColumn(
                name: "FieldTypeName",
                table: "FieldTypes",
                newName: "FieldName");

            migrationBuilder.RenameColumn(
                name: "FieldContactName",
                table: "FieldContacts",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "FieldId",
                table: "Fields",
                newName: "SportTypeId");

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "SportTypes",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "CreatedOn",
                table: "SportTypes",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "ModifiedOn",
                table: "SportTypes",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "FieldTypes",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "CreatedOn",
                table: "FieldTypes",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "ModifiedOn",
                table: "FieldTypes",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "FieldContacts",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "CreatedOn",
                table: "FieldContacts",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "ModifiedOn",
                table: "FieldContacts",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "Fields",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "CreatedOn",
                table: "Fields",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<Guid>(
                name: "FieldContactId",
                table: "Fields",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "FieldContactId1",
                table: "Fields",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "FieldTypeId",
                table: "Fields",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "FieldTypeId1",
                table: "Fields",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "ModifiedOn",
                table: "Fields",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "SportTypeId1",
                table: "Fields",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_SportTypes",
                table: "SportTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FieldTypes",
                table: "FieldTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FieldContacts",
                table: "FieldContacts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Fields",
                table: "Fields",
                column: "Id");

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
    }
}
