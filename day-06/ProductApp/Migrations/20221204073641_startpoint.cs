using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductApp.Migrations
{
    public partial class startpoint : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValue: "/images/products/default.jpg"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValue: "..."),
                    AtCreated = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
                    CategoryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId");
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 1, "Computer" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 2, "Electronic" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 3, "Smart Phones" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AtCreated", "CategoryId", "Description", "ImageUrl", "Price", "ProductName" },
                values: new object[] { 1, new DateTime(2022, 12, 4, 10, 36, 41, 419, DateTimeKind.Local).AddTicks(107), 1, "HP Laptop Touch your Dreams", "/images/products/1.jpg", 15000m, "HP Z Book" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AtCreated", "CategoryId", "Description", "ImageUrl", "Price", "ProductName" },
                values: new object[] { 2, new DateTime(2022, 12, 4, 10, 36, 41, 419, DateTimeKind.Local).AddTicks(124), 2, "Airpods for your ears", "/images/products/2.jpg", 5000m, "AirPods" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AtCreated", "CategoryId", "Price", "ProductName" },
                values: new object[] { 3, new DateTime(2022, 12, 4, 10, 36, 41, 419, DateTimeKind.Local).AddTicks(126), 3, 7000m, "Samsun Galaxy Note FE" });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
