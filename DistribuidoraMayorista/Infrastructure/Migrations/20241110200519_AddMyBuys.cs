using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddMyBuys : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Buys",
                columns: table => new
                {
                    BuysId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserBuysId = table.Column<int>(type: "INTEGER", nullable: false),
                    PurchaseDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    State = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buys", x => x.BuysId);
                });

            migrationBuilder.CreateTable(
                name: "DetailBuys",
                columns: table => new
                {
                    DetailId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProductDetailId = table.Column<int>(type: "INTEGER", nullable: false),
                    Amount = table.Column<int>(type: "INTEGER", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "TEXT", nullable: false),
                    BuysId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetailBuys", x => x.DetailId);
                    table.ForeignKey(
                        name: "FK_DetailBuys_Buys_BuysId",
                        column: x => x.BuysId,
                        principalTable: "Buys",
                        principalColumn: "BuysId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_DetailBuys_BuysId",
                table: "DetailBuys",
                column: "BuysId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetailBuys");

            migrationBuilder.DropTable(
                name: "Buys");
        }
    }
}
