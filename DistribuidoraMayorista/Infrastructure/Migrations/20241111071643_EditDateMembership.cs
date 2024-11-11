using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class EditDateMembership : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DateMembership",
                keyColumn: "MembershipPrice",
                keyValue: "$50.000/mes");

            migrationBuilder.InsertData(
                table: "DateMembership",
                columns: new[] { "MembershipPrice", "MembershipDescription", "MembershipTitle" },
                values: new object[] { 50000m, "Suscríbete a nuestra membresía y unete al club!Obtendras muchos beneficios, como un 20% de descuento en el precio total de todas tus compras.Estas a tan solo un simple paso de unirte!NO PIERDAS LA OPORTUNIDAD!", "Membresía Premium" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DateMembership",
                keyColumn: "MembershipPrice",
                keyValue: 50000m);

            migrationBuilder.InsertData(
                table: "DateMembership",
                columns: new[] { "MembershipPrice", "MembershipDescription", "MembershipTitle" },
                values: new object[] { "$50.000/mes", "Suscríbete a nuestra membresía y unete al club!Obtendras muchos beneficios, como un 20% de descuento en el precio total de todas tus compras.Estas a tan solo un simple paso de unirte!NO PIERDAS LA OPORTUNIDAD!", "Membresía Premium" });
        }
    }
}
