using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LAB1.Data.Migrations
{
    public partial class user2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "d962db90-0329-44b9-94f9-2ef870021bc8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "3410c44c-4e16-4325-8584-01bb542262ce");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ac681ac2-6a08-487a-bb58-7a5142bd6e00", "AQAAAAEAACcQAAAAEFqxsxhy09Wt75N1phQJa+SvfpW0Mqif/KgpIjIgvEAAu2KWpf2pHduh12VcrL0NDw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "42b37eb1-78d9-400d-a248-dccf76df3a3b", "AQAAAAEAACcQAAAAEEdO3EGccaDKH7IW3vS+FOLTOdOCywHAzhXZJPfd0O1fRrGxD5nNguRV9UwgFGta9A==" });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 4, 5, 3, 36, 40, 177, DateTimeKind.Local).AddTicks(9496));

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "ID",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 4, 5, 3, 36, 40, 178, DateTimeKind.Local).AddTicks(14));

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "ID",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 4, 5, 3, 36, 40, 178, DateTimeKind.Local).AddTicks(38));

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "ID",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2022, 4, 5, 3, 36, 40, 178, DateTimeKind.Local).AddTicks(58));

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "ID",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2022, 4, 5, 3, 36, 40, 178, DateTimeKind.Local).AddTicks(72));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 4, 3, 3, 36, 40, 171, DateTimeKind.Local).AddTicks(9982));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 4, 4, 3, 36, 40, 177, DateTimeKind.Local).AddTicks(7823));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
