using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BP.Migrations
{
    public partial class NewDataBaseChangeTwo : Migration
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
                name: "FK_Payment_Reservation_ReservationId",
                table: "Payment");

            migrationBuilder.DropIndex(
                name: "IX_Payment_ReservationId",
                table: "Payment");

            migrationBuilder.DropIndex(
                name: "IX_Match_ReservationId",
                table: "Match");

            migrationBuilder.DropColumn(
                name: "ReservationId",
                table: "Payment");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Match_Field_FieldId",
                table: "Match",
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

            migrationBuilder.AddColumn<Guid>(
                name: "ReservationId",
                table: "Payment",
                type: "uniqueidentifier",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Payment_ReservationId",
                table: "Payment",
                column: "ReservationId");

            migrationBuilder.CreateIndex(
                name: "IX_Match_ReservationId",
                table: "Match",
                column: "ReservationId");

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
                name: "FK_Payment_Reservation_ReservationId",
                table: "Payment",
                column: "ReservationId",
                principalTable: "Reservation",
                principalColumn: "ReservationId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
