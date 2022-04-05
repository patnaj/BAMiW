using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LAB1.Data.Migrations
{
    public partial class message2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                column: "ConcurrencyStamp",
                value: "e92c0c6e-b86e-430a-ad38-e1562d84e06f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "aa3c2afb-29f5-4c6e-b76d-b6579f14d137");

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

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Date", "Text", "UserId" },
                values: new object[] { 1, new DateTime(2022, 4, 3, 2, 19, 26, 837, DateTimeKind.Local).AddTicks(9165), "<b>Lorem Ipsum</b> is simply dummy text of the printing and typesetting industry.<br> Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,", 2 });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Date", "Text", "UserId" },
                values: new object[] { 2, new DateTime(2022, 4, 4, 2, 19, 26, 843, DateTimeKind.Local).AddTicks(6602), "<b>Lorem Ipsum</b> is <u>simply dummy text of the printing</u> and typesetting industry.<br> Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,", 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "4686fae3-9d65-47d0-aa45-deaa2e172ea7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "b2d327ed-72d6-46ad-8d87-03fc4b31f68b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "fecfee8e-36f0-4aac-ad44-c5902359825e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "56d4a82a-574b-497d-aea9-eca9509e1d5d");

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 4, 5, 1, 57, 24, 64, DateTimeKind.Local).AddTicks(1437));

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "ID",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 4, 5, 1, 57, 24, 69, DateTimeKind.Local).AddTicks(8831));

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "ID",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 4, 5, 1, 57, 24, 69, DateTimeKind.Local).AddTicks(8888));

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "ID",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2022, 4, 5, 1, 57, 24, 69, DateTimeKind.Local).AddTicks(8907));

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "ID",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2022, 4, 5, 1, 57, 24, 69, DateTimeKind.Local).AddTicks(8922));
        }
    }
}
