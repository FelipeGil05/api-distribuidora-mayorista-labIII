using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddDateMembership : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DateMembership",
                columns: table => new
                {
                    MembershipPrice = table.Column<string>(type: "TEXT", nullable: false),
                    MembershipTitle = table.Column<string>(type: "TEXT", nullable: false),
                    MembershipDescription = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DateMembership", x => x.MembershipPrice);
                });

            migrationBuilder.InsertData(
                table: "DateMembership",
                columns: new[] { "MembershipPrice", "MembershipDescription", "MembershipTitle" },
                values: new object[] { "$50.000/mes", "Suscríbete a nuestra membresía y unete al club!Obtendras muchos beneficios, como un 20% de descuento en el precio total de todas tus compras.Estas a tan solo un simple paso de unirte!NO PIERDAS LA OPORTUNIDAD!", "Membresía Premium" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DateMembership");
        }
    }
}
