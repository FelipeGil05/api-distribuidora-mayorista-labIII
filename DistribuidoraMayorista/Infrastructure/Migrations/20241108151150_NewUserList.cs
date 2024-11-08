using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class NewUserList : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Email", "Password", "UserName" },
                values: new object[] { "mateo@gmail.com", "MATEO", "Mateo" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Email", "Password", "UserName" },
                values: new object[] { "emanuel@gmail.com", "EMANUEL", "Emanuel" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Password", "UserName", "UserType" },
                values: new object[,]
                {
                    { 2, "admin2@gmail.com", "Admin123", "admin", "SysAdmin" },
                    { 4, "felipe@gmail.com", "FELIPE", "Felipe", "Admin" },
                    { 6, "sergio@gmail.com", "SERGIO", "Sergio", "Client" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Email", "Password", "UserName" },
                values: new object[] { "felipe@gmail.com", "FELIPE", "Felipe" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Email", "Password", "UserName" },
                values: new object[] { "sergio@gmail.com", "SERGIO", "Sergio" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Password", "UserName", "UserType" },
                values: new object[,]
                {
                    { 1, "admin2@gmail.com", "Admin123", "admin", "SysAdmin" },
                    { 2, "mateo@gmail.com", "MATEO", "Mateo", "Admin" },
                    { 4, "emanuel@gmail.com", "EMANUEL", "Emanuel", "Client" }
                });
        }
    }
}
