using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateMembership : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MembershipDescription",
                table: "Memberships");

            migrationBuilder.DropColumn(
                name: "MembershipName",
                table: "Memberships");

            migrationBuilder.RenameColumn(
                name: "MembershipPrice",
                table: "Memberships",
                newName: "StartDate");

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "Memberships",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Memberships",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Memberships_UserId",
                table: "Memberships",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Memberships_Users_UserId",
                table: "Memberships",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Memberships_Users_UserId",
                table: "Memberships");

            migrationBuilder.DropIndex(
                name: "IX_Memberships_UserId",
                table: "Memberships");

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "Memberships");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Memberships");

            migrationBuilder.RenameColumn(
                name: "StartDate",
                table: "Memberships",
                newName: "MembershipPrice");

            migrationBuilder.AddColumn<string>(
                name: "MembershipDescription",
                table: "Memberships",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MembershipName",
                table: "Memberships",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }
    }
}
