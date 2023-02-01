using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Uzum.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class f2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "CardNumber", "TotalSum" },
                values: new object[] { 1, "8600 0000 0000", 0m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
