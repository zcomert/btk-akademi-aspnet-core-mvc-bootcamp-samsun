using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductApp.Migrations
{
    public partial class cascase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "AtCreated",
                value: new DateTime(2022, 12, 11, 15, 3, 36, 718, DateTimeKind.Local).AddTicks(1632));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "AtCreated",
                value: new DateTime(2022, 12, 11, 15, 3, 36, 718, DateTimeKind.Local).AddTicks(1648));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "AtCreated",
                value: new DateTime(2022, 12, 11, 15, 3, 36, 718, DateTimeKind.Local).AddTicks(1650));

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "AtCreated",
                value: new DateTime(2022, 12, 11, 14, 59, 29, 459, DateTimeKind.Local).AddTicks(2763));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "AtCreated",
                value: new DateTime(2022, 12, 11, 14, 59, 29, 459, DateTimeKind.Local).AddTicks(2776));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "AtCreated",
                value: new DateTime(2022, 12, 11, 14, 59, 29, 459, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.SetNull);
        }
    }
}
