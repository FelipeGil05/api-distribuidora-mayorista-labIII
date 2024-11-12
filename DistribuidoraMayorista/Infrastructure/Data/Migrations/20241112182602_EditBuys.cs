using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class EditBuys : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProductDetailId",
                table: "DetailBuys",
                newName: "Quantity");

            migrationBuilder.RenameColumn(
                name: "Amount",
                table: "DetailBuys",
                newName: "ProductId");

            migrationBuilder.RenameColumn(
                name: "DetailId",
                table: "DetailBuys",
                newName: "DetailBuysId");

            migrationBuilder.AddColumn<string>(
                name: "ProductName",
                table: "DetailBuys",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductName",
                table: "DetailBuys");

            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "DetailBuys",
                newName: "ProductDetailId");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "DetailBuys",
                newName: "Amount");

            migrationBuilder.RenameColumn(
                name: "DetailBuysId",
                table: "DetailBuys",
                newName: "DetailId");
        }
    }
}
