using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Uzum.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class f3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Balance", "CardId", "FullName", "PasswordHash", "PhoneNumber", "Role", "UserName" },
                values: new object[] { 1, 10000000m, 1, "Adminbek Adminov", "CA5B9811BE39C13BA3F8265C006761214B85F36FFE177C482AA548A30FC2C8994F5AE33790A4AE6A302B65A05A906AAED4912F02C0E69FC6CE14A9C90AD998A0", "+998991234567", 1, "Admin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
