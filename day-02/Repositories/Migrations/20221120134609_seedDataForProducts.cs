using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repositories.Migrations
{
    public partial class seedDataForProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Price", "ProductName" },
                values: new object[] { 1, 17000m, "HP ZBook" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Price", "ProductName" },
                values: new object[] { 2, 5000m, "AirPods" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Price", "ProductName" },
                values: new object[] { 3, 7000m, "Samsun Galaxy Note FE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
