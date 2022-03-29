using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LAB1.Data.Migrations
{
    public partial class invoice_icon : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Icon",
                table: "Invoices",
                type: "TEXT",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "9a005ea9-eefc-4811-8277-f4a50daf3024");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "b978ad6a-3394-431a-bdd4-1f8424b409c5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "a1bfe65c-2fc9-4fdc-a719-e78014fb2580");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "46af1612-4628-4df0-b627-c682531a8163");

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 3, 29, 1, 5, 38, 176, DateTimeKind.Local).AddTicks(6195));

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "ID",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 3, 29, 1, 5, 38, 185, DateTimeKind.Local).AddTicks(6199));

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "ID",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 3, 29, 1, 5, 38, 185, DateTimeKind.Local).AddTicks(6279));

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "ID",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2022, 3, 29, 1, 5, 38, 185, DateTimeKind.Local).AddTicks(6303));

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "ID",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2022, 3, 29, 1, 5, 38, 185, DateTimeKind.Local).AddTicks(6322));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Icon",
                table: "Invoices");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "2cdcaa1f-6a79-499d-bc23-3fe42f46ef3f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "3e3dbee5-d0e7-4a0c-8922-ab9f31ffd845");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "1ba57ba7-0056-4a11-903f-de66d5874893");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "1011fc99-5a16-4a96-9fa3-7325cec1105d");

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 3, 29, 1, 3, 3, 923, DateTimeKind.Local).AddTicks(1342));

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "ID",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 3, 29, 1, 3, 3, 927, DateTimeKind.Local).AddTicks(3769));

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "ID",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 3, 29, 1, 3, 3, 927, DateTimeKind.Local).AddTicks(3802));

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "ID",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2022, 3, 29, 1, 3, 3, 927, DateTimeKind.Local).AddTicks(3816));

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "ID",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2022, 3, 29, 1, 3, 3, 927, DateTimeKind.Local).AddTicks(3831));
        }
    }
}
