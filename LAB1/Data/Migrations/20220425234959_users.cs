using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LAB1.Data.Migrations
{
    public partial class users : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "aae10eed-fec3-4bc8-a664-41d8e024133a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "70c59b7b-a9f0-4cb9-ae2d-fa1e8910cc17");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { 2, 1 });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { 2, 2 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "22cd61cb-e743-4b35-a9b5-b1f3c690e500", "AQAAAAEAACcQAAAAEJrFKCuhoBAYGVCWTS/V5JRjpniR0CxtrTJ/ie/I8aHD0TqRMSO+S5fOlJMFFLI7Fw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "30475b18-aa96-4f9a-b916-174b1fbe294f", "AQAAAAEAACcQAAAAEB8RzeBLHaHEtHGJ5sR/zVrWmFMBqIvG8hIs/dWqgCXaqmvbgdUeuxzsUH0ZvftJvg==" });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 4, 26, 1, 49, 59, 229, DateTimeKind.Local).AddTicks(9260));

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "ID",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 4, 26, 1, 49, 59, 229, DateTimeKind.Local).AddTicks(9589));

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "ID",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 4, 26, 1, 49, 59, 229, DateTimeKind.Local).AddTicks(9609));

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "ID",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2022, 4, 26, 1, 49, 59, 229, DateTimeKind.Local).AddTicks(9624));

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "ID",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2022, 4, 26, 1, 49, 59, 229, DateTimeKind.Local).AddTicks(9638));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 4, 24, 1, 49, 59, 226, DateTimeKind.Local).AddTicks(416));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 4, 25, 1, 49, 59, 229, DateTimeKind.Local).AddTicks(8141));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 2 });

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
    }
}
