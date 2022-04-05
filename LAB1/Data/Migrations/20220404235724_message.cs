using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LAB1.Data.Migrations
{
    public partial class message : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Text = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Messages_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Messages_UserId",
                table: "Messages",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Messages");

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
    }
}
