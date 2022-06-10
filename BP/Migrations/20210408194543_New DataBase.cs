using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BP.Migrations
{
    public partial class NewDataBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MatchUser_Matches_MatchId1",
                table: "MatchUser");

            migrationBuilder.DropForeignKey(
                name: "FK_MatchUser_Users_UserId1",
                table: "MatchUser");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Field_FieldId",
                table: "Reservations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MatchUser",
                table: "MatchUser");

            migrationBuilder.DropIndex(
                name: "IX_MatchUser_MatchId1",
                table: "MatchUser");

            migrationBuilder.DropIndex(
                name: "IX_MatchUser_UserId1",
                table: "MatchUser");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Reservations",
                table: "Reservations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Payments",
                table: "Payments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Matches",
                table: "Matches");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LoginPrivilages",
                table: "LoginPrivilages");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "UserTypeDictionary");

            migrationBuilder.DropColumn(
                name: "ModifiedOn",
                table: "UserTypeDictionary");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "RoleDictionary");

            migrationBuilder.DropColumn(
                name: "ModifiedOn",
                table: "RoleDictionary");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "MatchUser");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "MatchUser");

            migrationBuilder.DropColumn(
                name: "MatchId1",
                table: "MatchUser");

            migrationBuilder.DropColumn(
                name: "ModifiedOn",
                table: "MatchUser");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "MatchUser");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "LoginPrivilageId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "MatchUsersId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ModifiedOn",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "ModifiedOn",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "ReservationMatchId",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "ReservationPaymentId",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "ModifiedOn",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "PaymentStatusDictionaryId",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "ModifiedOn",
                table: "Matches");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "User");

            migrationBuilder.RenameTable(
                name: "Reservations",
                newName: "Reservation");

            migrationBuilder.RenameTable(
                name: "Payments",
                newName: "Payment");

            migrationBuilder.RenameTable(
                name: "Matches",
                newName: "Match");

            migrationBuilder.RenameTable(
                name: "LoginPrivilages",
                newName: "LoginPrivilage");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "UserTypeDictionary",
                newName: "UserTypeDictionaryId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "RoleDictionary",
                newName: "UserTypeDictionaryId");

            migrationBuilder.RenameColumn(
                name: "UserTypeDictionaryId",
                table: "User",
                newName: "MatchId");

            migrationBuilder.RenameColumn(
                name: "RoleDictionaryId",
                table: "User",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "ReservationStatusDictionaryId",
                table: "Reservation",
                newName: "ReservationId");

            migrationBuilder.RenameIndex(
                name: "IX_Reservations_FieldId",
                table: "Reservation",
                newName: "IX_Reservation_FieldId");

            migrationBuilder.RenameColumn(
                name: "ReservationPaymentId",
                table: "Payment",
                newName: "PaymentId");

            migrationBuilder.RenameColumn(
                name: "ReservationMatchId",
                table: "Match",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "MatchUsersId",
                table: "Match",
                newName: "ReservationId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Match",
                newName: "MatchId");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "UserTypeDictionary",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "RoleDictionary",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "Reservation",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "PaymentId",
                table: "Reservation",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "MatchId",
                table: "Reservation",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "FieldId",
                table: "Reservation",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Reservation",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ReservationId",
                table: "Payment",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Payment",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "LoginPrivilage",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<Guid>(
                name: "LoginPrivilageId",
                table: "LoginPrivilage",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_MatchUser",
                table: "MatchUser",
                columns: new[] { "MatchId", "UserId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reservation",
                table: "Reservation",
                column: "ReservationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Payment",
                table: "Payment",
                column: "PaymentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Match",
                table: "Match",
                column: "MatchId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LoginPrivilage",
                table: "LoginPrivilage",
                column: "Login");

            migrationBuilder.CreateTable(
                name: "MatchUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MatchId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ModifiedOn = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MatchUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MatchUsers_Match_MatchId",
                        column: x => x.MatchId,
                        principalTable: "Match",
                        principalColumn: "MatchId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MatchUsers_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserTypeDictionary_UserId",
                table: "UserTypeDictionary",
                column: "UserId",
                unique: true,
                filter: "[UserId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_RoleDictionary_UserId",
                table: "RoleDictionary",
                column: "UserId",
                unique: true,
                filter: "[UserId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_MatchUser_UserId",
                table: "MatchUser",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservation_MatchId",
                table: "Reservation",
                column: "MatchId",
                unique: true,
                filter: "[MatchId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Reservation_PaymentId",
                table: "Reservation",
                column: "PaymentId",
                unique: true,
                filter: "[PaymentId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Reservation_UserId",
                table: "Reservation",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_ReservationId",
                table: "Payment",
                column: "ReservationId");

            migrationBuilder.CreateIndex(
                name: "IX_Match_FieldId",
                table: "Match",
                column: "FieldId");

            migrationBuilder.CreateIndex(
                name: "IX_Match_ReservationId",
                table: "Match",
                column: "ReservationId");

            migrationBuilder.CreateIndex(
                name: "IX_LoginPrivilage_UserId",
                table: "LoginPrivilage",
                column: "UserId",
                unique: true,
                filter: "[UserId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_MatchUsers_MatchId",
                table: "MatchUsers",
                column: "MatchId");

            migrationBuilder.CreateIndex(
                name: "IX_MatchUsers_UserId",
                table: "MatchUsers",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_LoginPrivilage_User_UserId",
                table: "LoginPrivilage",
                column: "UserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

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
                name: "FK_MatchUser_Match_MatchId",
                table: "MatchUser",
                column: "MatchId",
                principalTable: "Match",
                principalColumn: "MatchId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MatchUser_User_UserId",
                table: "MatchUser",
                column: "UserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_Reservation_ReservationId",
                table: "Payment",
                column: "ReservationId",
                principalTable: "Reservation",
                principalColumn: "ReservationId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_Field_FieldId",
                table: "Reservation",
                column: "FieldId",
                principalTable: "Field",
                principalColumn: "FieldId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_Match_MatchId",
                table: "Reservation",
                column: "MatchId",
                principalTable: "Match",
                principalColumn: "MatchId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_Payment_PaymentId",
                table: "Reservation",
                column: "PaymentId",
                principalTable: "Payment",
                principalColumn: "PaymentId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_User_UserId",
                table: "Reservation",
                column: "UserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RoleDictionary_User_UserId",
                table: "RoleDictionary",
                column: "UserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserTypeDictionary_User_UserId",
                table: "UserTypeDictionary",
                column: "UserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LoginPrivilage_User_UserId",
                table: "LoginPrivilage");

            migrationBuilder.DropForeignKey(
                name: "FK_Match_Field_FieldId",
                table: "Match");

            migrationBuilder.DropForeignKey(
                name: "FK_Match_Reservation_ReservationId",
                table: "Match");

            migrationBuilder.DropForeignKey(
                name: "FK_MatchUser_Match_MatchId",
                table: "MatchUser");

            migrationBuilder.DropForeignKey(
                name: "FK_MatchUser_User_UserId",
                table: "MatchUser");

            migrationBuilder.DropForeignKey(
                name: "FK_Payment_Reservation_ReservationId",
                table: "Payment");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_Field_FieldId",
                table: "Reservation");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_Match_MatchId",
                table: "Reservation");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_Payment_PaymentId",
                table: "Reservation");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_User_UserId",
                table: "Reservation");

            migrationBuilder.DropForeignKey(
                name: "FK_RoleDictionary_User_UserId",
                table: "RoleDictionary");

            migrationBuilder.DropForeignKey(
                name: "FK_UserTypeDictionary_User_UserId",
                table: "UserTypeDictionary");

            migrationBuilder.DropTable(
                name: "MatchUsers");

            migrationBuilder.DropIndex(
                name: "IX_UserTypeDictionary_UserId",
                table: "UserTypeDictionary");

            migrationBuilder.DropIndex(
                name: "IX_RoleDictionary_UserId",
                table: "RoleDictionary");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MatchUser",
                table: "MatchUser");

            migrationBuilder.DropIndex(
                name: "IX_MatchUser_UserId",
                table: "MatchUser");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Reservation",
                table: "Reservation");

            migrationBuilder.DropIndex(
                name: "IX_Reservation_MatchId",
                table: "Reservation");

            migrationBuilder.DropIndex(
                name: "IX_Reservation_PaymentId",
                table: "Reservation");

            migrationBuilder.DropIndex(
                name: "IX_Reservation_UserId",
                table: "Reservation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Payment",
                table: "Payment");

            migrationBuilder.DropIndex(
                name: "IX_Payment_ReservationId",
                table: "Payment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Match",
                table: "Match");

            migrationBuilder.DropIndex(
                name: "IX_Match_FieldId",
                table: "Match");

            migrationBuilder.DropIndex(
                name: "IX_Match_ReservationId",
                table: "Match");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LoginPrivilage",
                table: "LoginPrivilage");

            migrationBuilder.DropIndex(
                name: "IX_LoginPrivilage_UserId",
                table: "LoginPrivilage");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Reservation");

            migrationBuilder.DropColumn(
                name: "ReservationId",
                table: "Payment");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Payment");

            migrationBuilder.DropColumn(
                name: "LoginPrivilageId",
                table: "LoginPrivilage");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "Reservation",
                newName: "Reservations");

            migrationBuilder.RenameTable(
                name: "Payment",
                newName: "Payments");

            migrationBuilder.RenameTable(
                name: "Match",
                newName: "Matches");

            migrationBuilder.RenameTable(
                name: "LoginPrivilage",
                newName: "LoginPrivilages");

            migrationBuilder.RenameColumn(
                name: "UserTypeDictionaryId",
                table: "UserTypeDictionary",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "UserTypeDictionaryId",
                table: "RoleDictionary",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "MatchId",
                table: "Users",
                newName: "UserTypeDictionaryId");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Users",
                newName: "RoleDictionaryId");

            migrationBuilder.RenameColumn(
                name: "ReservationId",
                table: "Reservations",
                newName: "ReservationStatusDictionaryId");

            migrationBuilder.RenameIndex(
                name: "IX_Reservation_FieldId",
                table: "Reservations",
                newName: "IX_Reservations_FieldId");

            migrationBuilder.RenameColumn(
                name: "PaymentId",
                table: "Payments",
                newName: "ReservationPaymentId");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Matches",
                newName: "ReservationMatchId");

            migrationBuilder.RenameColumn(
                name: "ReservationId",
                table: "Matches",
                newName: "MatchUsersId");

            migrationBuilder.RenameColumn(
                name: "MatchId",
                table: "Matches",
                newName: "Id");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "UserTypeDictionary",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "CreatedOn",
                table: "UserTypeDictionary",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "ModifiedOn",
                table: "UserTypeDictionary",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "RoleDictionary",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "CreatedOn",
                table: "RoleDictionary",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "ModifiedOn",
                table: "RoleDictionary",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "MatchUser",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "CreatedOn",
                table: "MatchUser",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<Guid>(
                name: "MatchId1",
                table: "MatchUser",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "ModifiedOn",
                table: "MatchUser",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UserId1",
                table: "MatchUser",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "Users",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "CreatedOn",
                table: "Users",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<Guid>(
                name: "LoginPrivilageId",
                table: "Users",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "MatchUsersId",
                table: "Users",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "ModifiedOn",
                table: "Users",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "Reservations",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "PaymentId",
                table: "Reservations",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "MatchId",
                table: "Reservations",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "FieldId",
                table: "Reservations",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "Reservations",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "CreatedOn",
                table: "Reservations",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "ModifiedOn",
                table: "Reservations",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ReservationMatchId",
                table: "Reservations",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "ReservationPaymentId",
                table: "Reservations",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<int>(
                name: "StatusId",
                table: "Reservations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "Payments",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "CreatedOn",
                table: "Payments",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "ModifiedOn",
                table: "Payments",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "PaymentStatusDictionaryId",
                table: "Payments",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<int>(
                name: "StatusId",
                table: "Payments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "CreatedOn",
                table: "Matches",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "ModifiedOn",
                table: "Matches",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "LoginPrivilages",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_MatchUser",
                table: "MatchUser",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reservations",
                table: "Reservations",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Payments",
                table: "Payments",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Matches",
                table: "Matches",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LoginPrivilages",
                table: "LoginPrivilages",
                column: "Login");

            migrationBuilder.CreateIndex(
                name: "IX_MatchUser_MatchId1",
                table: "MatchUser",
                column: "MatchId1");

            migrationBuilder.CreateIndex(
                name: "IX_MatchUser_UserId1",
                table: "MatchUser",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_MatchUser_Matches_MatchId1",
                table: "MatchUser",
                column: "MatchId1",
                principalTable: "Matches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MatchUser_Users_UserId1",
                table: "MatchUser",
                column: "UserId1",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Field_FieldId",
                table: "Reservations",
                column: "FieldId",
                principalTable: "Field",
                principalColumn: "FieldId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
