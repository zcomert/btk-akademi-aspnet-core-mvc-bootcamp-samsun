using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductApp.Migrations
{
    public partial class updateRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4ff589a4-e774-46a0-a38a-526928799214");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "81ec2092-cef6-4790-8332-7a444593cc65");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d5653a32-2edb-4d8b-b663-506e12affb03");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "554cd9d4-75ca-4e19-a1c9-f359efbc94e4", "1c8daee9-b9bc-47ba-8ded-3bdb45d5fa5a", "Editor", "EDITOR" },
                    { "8014b9e2-cf35-4941-85dc-649e4ae16fc9", "611dcecb-cff1-45b7-b736-b28f1822d3b6", "User", "USER" },
                    { "b0c51af9-d1ff-46ba-9bd5-9d6996caaf5d", "374f0bd3-9b6a-4204-b7cb-6638d5f0f702", "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "AtCreated",
                value: new DateTime(2022, 12, 18, 10, 58, 55, 533, DateTimeKind.Local).AddTicks(5443));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "AtCreated",
                value: new DateTime(2022, 12, 18, 10, 58, 55, 533, DateTimeKind.Local).AddTicks(5462));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "AtCreated",
                value: new DateTime(2022, 12, 18, 10, 58, 55, 533, DateTimeKind.Local).AddTicks(5465));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "554cd9d4-75ca-4e19-a1c9-f359efbc94e4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8014b9e2-cf35-4941-85dc-649e4ae16fc9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b0c51af9-d1ff-46ba-9bd5-9d6996caaf5d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4ff589a4-e774-46a0-a38a-526928799214", "3899316d-498f-4b83-9486-0ea0a2ccd654", "editor", null },
                    { "81ec2092-cef6-4790-8332-7a444593cc65", "f79b5fef-758c-4a08-b647-888642247d4c", "user", null },
                    { "d5653a32-2edb-4d8b-b663-506e12affb03", "5cda68e5-ce7b-4137-8cfd-819a29906c06", "admin", null }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "AtCreated",
                value: new DateTime(2022, 12, 17, 12, 0, 31, 676, DateTimeKind.Local).AddTicks(6741));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "AtCreated",
                value: new DateTime(2022, 12, 17, 12, 0, 31, 676, DateTimeKind.Local).AddTicks(6755));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "AtCreated",
                value: new DateTime(2022, 12, 17, 12, 0, 31, 676, DateTimeKind.Local).AddTicks(6756));
        }
    }
}
