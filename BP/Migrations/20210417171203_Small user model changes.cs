using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BP.Migrations
{
    public partial class Smallusermodelchanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_UserTypeDictionary_UserId",
                table: "UserTypeDictionary");

            migrationBuilder.DropIndex(
                name: "IX_RoleDictionary_UserId",
                table: "RoleDictionary");

            migrationBuilder.DropIndex(
                name: "IX_LoginPrivilage_UserId",
                table: "LoginPrivilage");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "User");

            migrationBuilder.DropColumn(
                name: "LastPasswordChangeDate",
                table: "User");

            migrationBuilder.DropColumn(
                name: "MatchId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "ModifiedOn",
                table: "User");

            migrationBuilder.CreateIndex(
                name: "IX_UserTypeDictionary_UserId",
                table: "UserTypeDictionary",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleDictionary_UserId",
                table: "RoleDictionary",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_LoginPrivilage_UserId",
                table: "LoginPrivilage",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_UserTypeDictionary_UserId",
                table: "UserTypeDictionary");

            migrationBuilder.DropIndex(
                name: "IX_RoleDictionary_UserId",
                table: "RoleDictionary");

            migrationBuilder.DropIndex(
                name: "IX_LoginPrivilage_UserId",
                table: "LoginPrivilage");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastPasswordChangeDate",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "MatchId",
                table: "User",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedOn",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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
                name: "IX_LoginPrivilage_UserId",
                table: "LoginPrivilage",
                column: "UserId",
                unique: true,
                filter: "[UserId] IS NOT NULL");
        }
    }
}
