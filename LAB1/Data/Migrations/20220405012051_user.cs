using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LAB1.Data.Migrations
{
    public partial class user : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "ba945c6f-330d-486d-a23a-bbc3df6d54cc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "ea446ad1-a8e9-4916-b2f3-13221e4ea777");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "38f49cd7-0eba-4c6b-9642-6c7560a31bd1", "AQAAAAEAACcQAAAAEPOtCIqzRAthmz6IIcBAVTXgUWPkekvgjPgays7FF2MEpF7OYQ2mbahmZ8oy44wUDQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "20e4f1ef-fd38-4d17-b986-7b4d8fbf3c0a", "AQAAAAEAACcQAAAAEAqlbdIn2VZIh0fKZYbq2Hr7kvFvuRBq7iA341IDGU5zVpxtflM7zl1x7AzJepPwhA==" });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 4, 5, 3, 20, 50, 837, DateTimeKind.Local).AddTicks(9430));

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "ID",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 4, 5, 3, 20, 50, 837, DateTimeKind.Local).AddTicks(9958));

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "ID",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 4, 5, 3, 20, 50, 837, DateTimeKind.Local).AddTicks(9982));

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "ID",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2022, 4, 5, 3, 20, 50, 838, DateTimeKind.Local).AddTicks(1));

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "ID",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2022, 4, 5, 3, 20, 50, 838, DateTimeKind.Local).AddTicks(16));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 4, 3, 3, 20, 50, 831, DateTimeKind.Local).AddTicks(7666));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 4, 4, 3, 20, 50, 837, DateTimeKind.Local).AddTicks(7872));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "88465b2c-80df-4a53-99a0-fd98f4d873e1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "866e5622-1083-49fe-9ae5-a23a22e9890e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e92c0c6e-b86e-430a-ad38-e1562d84e06f", "vCBk9YvE1nySW0iK0xsk8zfdfuo=" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "aa3c2afb-29f5-4c6e-b76d-b6579f14d137", "/hQQQoX8WPWsR+ize8w/488lNDE=" });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 4, 5, 2, 19, 26, 843, DateTimeKind.Local).AddTicks(8170));

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "ID",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 4, 5, 2, 19, 26, 843, DateTimeKind.Local).AddTicks(8704));

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "ID",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 4, 5, 2, 19, 26, 843, DateTimeKind.Local).AddTicks(8728));

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "ID",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2022, 4, 5, 2, 19, 26, 843, DateTimeKind.Local).AddTicks(8747));

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "ID",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2022, 4, 5, 2, 19, 26, 843, DateTimeKind.Local).AddTicks(8761));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 4, 3, 2, 19, 26, 837, DateTimeKind.Local).AddTicks(9165));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 4, 4, 2, 19, 26, 843, DateTimeKind.Local).AddTicks(6602));
        }
    }
}
