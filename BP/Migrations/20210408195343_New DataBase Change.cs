using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BP.Migrations
{
    public partial class NewDataBaseChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Match_Field_FieldId",
                table: "Match");

            migrationBuilder.DropForeignKey(
                name: "FK_Match_Reservation_ReservationId",
                table: "Match");

            migrationBuilder.DropForeignKey(
                name: "FK_SsportType_Field_FieldId",
                table: "SsportType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SsportType",
                table: "SsportType");

            migrationBuilder.RenameTable(
                name: "SsportType",
                newName: "SportType");

            migrationBuilder.AlterColumn<Guid>(
                name: "ReservationId",
                table: "Match",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "FieldId",
                table: "Match",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SportType",
                table: "SportType",
                column: "FieldId");

            migrationBuilder.AddForeignKey(
                name: "FK_Match_Field_FieldId",
                table: "Match",
                column: "FieldId",
                principalTable: "Field",
                principalColumn: "FieldId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Match_Reservation_ReservationId",
                table: "Match",
                column: "ReservationId",
                principalTable: "Reservation",
                principalColumn: "ReservationId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SportType_Field_FieldId",
                table: "SportType",
                column: "FieldId",
                principalTable: "Field",
                principalColumn: "FieldId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Match_Field_FieldId",
                table: "Match");

            migrationBuilder.DropForeignKey(
                name: "FK_Match_Reservation_ReservationId",
                table: "Match");

            migrationBuilder.DropForeignKey(
                name: "FK_SportType_Field_FieldId",
                table: "SportType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SportType",
                table: "SportType");

            migrationBuilder.RenameTable(
                name: "SportType",
                newName: "SsportType");

            migrationBuilder.AlterColumn<Guid>(
                name: "ReservationId",
                table: "Match",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "FieldId",
                table: "Match",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_SsportType",
                table: "SsportType",
                column: "FieldId");

            migrationBuilder.AddForeignKey(
                name: "FK_Match_Field_FieldId",
                table: "Match",
                column: "FieldId",
                principalTable: "Field",
                principalColumn: "FieldId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Match_Reservation_ReservationId",
                table: "Match",
                column: "ReservationId",
                principalTable: "Reservation",
                principalColumn: "ReservationId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SsportType_Field_FieldId",
                table: "SsportType",
                column: "FieldId",
                principalTable: "Field",
                principalColumn: "FieldId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
