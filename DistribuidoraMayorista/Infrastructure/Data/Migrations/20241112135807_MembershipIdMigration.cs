using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class MembershipIdMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_DateMembership",
                table: "DateMembership");

            migrationBuilder.DeleteData(
                table: "DateMembership",
                keyColumn: "MembershipPrice",
                keyValue: 50000m);

            migrationBuilder.AddColumn<int>(
                name: "MembershipId",
                table: "DateMembership",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0)
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_DateMembership",
                table: "DateMembership",
                column: "MembershipId");

            migrationBuilder.InsertData(
                table: "DateMembership",
                columns: new[] { "MembershipId", "MembershipDescription", "MembershipPrice", "MembershipTitle" },
                values: new object[] { 1, "Suscríbete a nuestra membresía y unete al club!Obtendras muchos beneficios, como un 20% de descuento en el precio total de todas tus compras.Estas a tan solo un simple paso de unirte!NO PIERDAS LA OPORTUNIDAD!", 50000m, "Membresía Premium" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_DateMembership",
                table: "DateMembership");

            migrationBuilder.DeleteData(
                table: "DateMembership",
                keyColumn: "MembershipId",
                keyColumnType: "INTEGER",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "MembershipId",
                table: "DateMembership");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DateMembership",
                table: "DateMembership",
                column: "MembershipPrice");

            migrationBuilder.InsertData(
                table: "DateMembership",
                columns: new[] { "MembershipPrice", "MembershipDescription", "MembershipTitle" },
                values: new object[] { 50000m, "Suscríbete a nuestra membresía y unete al club!Obtendras muchos beneficios, como un 20% de descuento en el precio total de todas tus compras.Estas a tan solo un simple paso de unirte!NO PIERDAS LA OPORTUNIDAD!", "Membresía Premium" });
        }
    }
}
