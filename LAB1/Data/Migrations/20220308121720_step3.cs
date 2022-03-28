using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LAB1.Data.Migrations
{
    public partial class step3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "1a5974b6-190e-4485-8d84-3ee4725be252");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "0b37a46d-a69e-4925-8e3b-71da129ef802");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "090df916-32b0-4c85-b56c-00f740e5a12b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "f8e26a78-3bf3-42d3-8091-92f71e69ff6d");

            migrationBuilder.InsertData(
                table: "Invoices",
                columns: new[] { "ID", "Address", "Date", "InvoiceModelID", "UserID" },
                values: new object[] { 1, "Fairview 5451, New Orleans - 6420, The Bahamas", new DateTime(2022, 3, 8, 13, 17, 20, 78, DateTimeKind.Local).AddTicks(6003), null, 1 });

            migrationBuilder.InsertData(
                table: "Invoices",
                columns: new[] { "ID", "Address", "Date", "InvoiceModelID", "UserID" },
                values: new object[] { 2, "Garland - 2327, Dominican Republic", new DateTime(2022, 3, 8, 13, 17, 20, 83, DateTimeKind.Local).AddTicks(8240), null, 1 });

            migrationBuilder.InsertData(
                table: "Invoices",
                columns: new[] { "ID", "Address", "Date", "InvoiceModelID", "UserID" },
                values: new object[] { 3, "Ellerslie 5206, Wien - 7026, Morocco", new DateTime(2022, 3, 8, 13, 17, 20, 83, DateTimeKind.Local).AddTicks(8279), null, 2 });

            migrationBuilder.InsertData(
                table: "Invoices",
                columns: new[] { "ID", "Address", "Date", "InvoiceModelID", "UserID" },
                values: new object[] { 4, "Garfield 8152, Cincinnati - 6755, Djibouti", new DateTime(2022, 3, 8, 13, 17, 20, 83, DateTimeKind.Local).AddTicks(8294), null, 1 });

            migrationBuilder.InsertData(
                table: "Invoices",
                columns: new[] { "ID", "Address", "Date", "InvoiceModelID", "UserID" },
                values: new object[] { 5, "Chesterfield  3014, Columbus - 2530, Grenada", new DateTime(2022, 3, 8, 13, 17, 20, 83, DateTimeKind.Local).AddTicks(8308), null, 1 });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 3, 1f, 1, 92.17f, "	Sprouts - Pea	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 106, 76f, 4, 28.36f, "	Veal - Round, Eye Of	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 101, 93f, 4, 81.67f, "	Pumpkin	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 100, 31f, 4, 26.09f, "	Bread - Sticks, Thin, Plain	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 92, 55f, 4, 30f, "	Cheese - Brie Roitelet	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 89, 98f, 4, 58.51f, "	Arctic Char - Fresh, Whole	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 86, 59f, 4, 74.67f, "	Squid Ink	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 81, 63f, 4, 62.63f, "	Coffee - French Vanilla Frothy	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 76, 94f, 4, 74.74f, "	Muffin Carrot - Individual	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 72, 36f, 4, 99.16f, "	Onion - Dried	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 61, 100f, 4, 77.25f, "	Juice - Orangina	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 60, 94f, 4, 42.47f, "	Wasabi Paste	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 56, 98f, 4, 91.53f, "	V8 Pet	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 53, 14f, 4, 63.23f, "	Napkin - Cocktail,beige 2 - Ply	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 43, 24f, 4, 81.02f, "	Wine - Alsace Gewurztraminer	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 117, 20f, 4, 87.87f, "	Water - Perrier	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 39, 98f, 4, 81.54f, "	Asparagus - White, Fresh	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 35, 94f, 4, 52.73f, "	Vinegar - White	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 31, 99f, 4, 97.28f, "	Red Cod Fillets - 225g	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 29, 45f, 4, 52.49f, "	Chivas Regal - 12 Year Old	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 24, 84f, 4, 77.14f, "	Squash - Guords	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 23, 69f, 4, 83.26f, "	Cheese - Brie,danish	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 18, 10f, 4, 38.53f, "	Tea - Herbal I Love Lemon	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 17, 99f, 4, 56.06f, "	Marjoram - Fresh	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 2, 14f, 4, 79.02f, "	Steam Pan - Half Size Deep	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 136, 74f, 3, 5.07f, "	Cake - Pancake	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 134, 27f, 3, 86.08f, "	Milk 2% 500 Ml	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 125, 27f, 3, 59.11f, "	Beef - Montreal Smoked Brisket	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 115, 29f, 3, 40.92f, "	Pears - Anjou	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 102, 80f, 3, 48.09f, "	Carbonated Water - Blackberry	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 96, 52f, 3, 8.28f, "	Steampan - Half Size Shallow	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 36, 82f, 4, 26.06f, "	Temperature Recording Station	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 88, 46f, 3, 89.72f, "	Pork - Belly Fresh	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 120, 34f, 4, 73.94f, "	Phyllo Dough	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 127, 60f, 4, 62.41f, "	Worcestershire Sauce	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 108, 11f, 5, 77.99f, "	Wine - Magnotta, Merlot Sr Vqa	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 107, 25f, 5, 66.08f, "	Flour - Strong	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 99, 29f, 5, 68.14f, "	Bagel - Whole White Sesame	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 97, 20f, 5, 85.42f, "	Pail With Metal Handle 16l White	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 94, 94f, 5, 18.8f, "	Juice - Clam, 46 Oz	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 93, 79f, 5, 16.36f, "	Wine - Cotes Du Rhone Parallele	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 85, 87f, 5, 77.8f, "	Chips - Assorted	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 74, 7f, 5, 28.48f, "	Melon - Watermelon, Seedless	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 73, 72f, 5, 23.76f, "	Sprouts Dikon	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 71, 72f, 5, 14.04f, "	Wine - George Duboeuf Rose	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 70, 21f, 5, 89.4f, "	Napkin White - Starched	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 69, 26f, 5, 18.31f, "	Nut - Pumpkin Seeds	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 68, 10f, 5, 28.9f, "	Veal - Bones	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 67, 58f, 5, 95.07f, "	Syrup - Pancake	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 126, 84f, 4, 83.06f, "	Cookies Cereal Nut	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 62, 56f, 5, 19.46f, "	Wine - White, Antinore Orvieto	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 37, 72f, 5, 61.11f, "	Berry Brulee	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 28, 26f, 5, 21.42f, "	Broom And Brush Rack Black	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 27, 61f, 5, 72.58f, "	Beans - Fava Fresh	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 25, 22f, 5, 40.23f, "	Bag - Bread, White, Plain	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 22, 54f, 5, 98.37f, "	Crab - Meat Combo	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 20, 19f, 5, 78.31f, "	Lamb - Shoulder, Boneless	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 13, 34f, 5, 80.34f, "	Marjoram - Fresh	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 11, 71f, 5, 33.12f, "	Bagel - Sesame Seed Presliced	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 9, 1f, 5, 51.88f, "	Scallops 60/80 Iqf	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 8, 33f, 5, 43.51f, "	Mushroom - Crimini	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 6, 90f, 5, 90.38f, "	Parsley Italian - Fresh	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 133, 47f, 4, 46.02f, "	Tomatoes - Yellow Hot House	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 132, 96f, 4, 54.55f, "	Soap - Hand Soap	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 130, 55f, 4, 26.29f, "	Galliano	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 59, 96f, 5, 17.84f, "	Beer - Sleemans Honey Brown	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 80, 25f, 3, 78.32f, "	Oil - Avocado	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 78, 37f, 3, 26.21f, "	Halibut - Fletches	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 66, 63f, 3, 42.36f, "	Seaweed Green Sheets	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 54, 73f, 2, 72.63f, "	Phyllo Dough	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 52, 42f, 2, 48.76f, "	Chicken - Thigh, Bone In	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 51, 20f, 2, 47.54f, "	Bagelers - Cinn / Brown Sugar	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 50, 25f, 2, 71.98f, "	Fish - Atlantic Salmon, Cold	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 49, 43f, 2, 80.98f, "	Cheese - Le Cheve Noir	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 46, 41f, 2, 49.56f, "	Sobe - Lizard Fuel	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 42, 86f, 2, 58f, "	Chocolate - Pistoles, Lactee, Milk	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 15, 95f, 2, 46.69f, "	Tortillas - Flour, 12	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 131, 74f, 1, 72.52f, "	Bread - Flat Bread	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 119, 8f, 1, 46.43f, "	Muffin Batt - Carrot Spice	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 118, 6f, 1, 25.74f, "	Gelatine Leaves - Envelopes	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 113, 99f, 1, 38.98f, "	Bread - Bistro Sour	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 103, 45f, 1, 44.76f, "	Muffins - Assorted	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 91, 48f, 1, 20.79f, "	Table Cloth - 53x69 Colour	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 64, 11f, 2, 5.48f, "	Juice - Lemon	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 87, 6f, 1, 20.95f, "	Flower - Daisies	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 75, 41f, 1, 4.81f, "	Cucumber - English	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 65, 8f, 1, 77.66f, "	Cup - 8oz Coffee Perforated	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 58, 44f, 1, 37.51f, "	Wine - Port Late Bottled Vintage	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 41, 78f, 1, 69.58f, "	Oranges - Navel, 72	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 40, 60f, 1, 57.39f, "	Soup - Campbells, Chix Gumbo	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 38, 69f, 1, 83.18f, "	Pesto - Primerba, Paste	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 33, 7f, 1, 79.69f, "	Mix - Cocktail Ice Cream	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 32, 18f, 1, 36.43f, "	Beans - Fine	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 26, 21f, 1, 4.5f, "	Cookie Dough - Double	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 19, 66f, 1, 53.64f, "	Cut Wakame - Hanawakaba	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 16, 77f, 1, 62.66f, "	Ecolab - Solid Fusion	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 14, 4f, 1, 93.08f, "	Veal - Kidney	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 5, 93f, 1, 8.05f, "	Tamarind Paste	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 4, 77f, 1, 92.06f, "	Apple - Custard	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 82, 14f, 1, 61.45f, "	Lemon Grass	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 77, 57f, 2, 47.1f, "	Soup - Knorr, Ministrone	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 79, 14f, 2, 41.65f, "	Sachet	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 83, 68f, 2, 40.33f, "	Nestea - Iced Tea	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 63, 75f, 3, 36.87f, "	Lychee	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 57, 58f, 3, 59.88f, "	Stock - Chicken, White	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 55, 35f, 3, 21.54f, "	Soup - Campbells - Tomato	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 48, 3f, 3, 50.02f, "	Wine - Red, Colio Cabernet	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 47, 73f, 3, 87.54f, "	Container - Foam Dixie 12 Oz	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 45, 22f, 3, 73.08f, "	Spice - Peppercorn Melange	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 44, 52f, 3, 38.11f, "	Nantucket - Pomegranate Pear	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 34, 18f, 3, 19.34f, "	Pasta - Rotini, Dry	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 30, 93f, 3, 38.57f, "	Crackers - Water	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 21, 66f, 3, 85.09f, "	Wine - Ej Gallo Sierra Valley	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 12, 77f, 3, 24.05f, "	Mushroom - Enoki, Dry	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 10, 50f, 3, 32.92f, "	Glass Clear 8 Oz	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 7, 71f, 3, 3.24f, "	Steam Pan - Half Size Deep	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 1, 17f, 3, 87.83f, "	Crackers - Water	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 135, 16f, 2, 43.96f, "	Glove - Cutting	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 129, 30f, 2, 83.7f, "	Venison - Striploin	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 128, 72f, 2, 16.46f, "	Wine - Barbera Alba Doc 2001	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 84, 89f, 2, 5.22f, "	Cleaner - Pine Sol	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 90, 48f, 2, 18.61f, "	Cakes Assorted	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 95, 67f, 2, 50.93f, "	Smoked Paprika	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 98, 76f, 2, 7.12f, "	Flour - Buckwheat, Dark	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 104, 76f, 2, 84.54f, "	Lettuce - Baby Salad Greens	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 105, 20f, 2, 8.17f, "	Oil - Sunflower	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 111, 28f, 5, 57.48f, "	Cheese - Woolwich Goat, Log	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 109, 2f, 2, 48.58f, "	Chocolate - Semi Sweet	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 112, 11f, 2, 14.03f, "	Muffin Batt - Carrot Spice	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 114, 94f, 2, 98.08f, "	Rice - Brown	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 116, 59f, 2, 54.2f, "	Flour - Corn, Fine	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 122, 22f, 2, 76.17f, "	Sauce - Fish 25 Ozf Bottle	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 123, 22f, 2, 83.75f, "	Strawberries - California	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 124, 82f, 2, 47.63f, "	Pasta - Tortellini, Fresh	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 110, 99f, 2, 81.33f, "	Pepper - Green Thai	" });

            migrationBuilder.InsertData(
                table: "InvoiceItems",
                columns: new[] { "ID", "Amount", "IvoiceID", "Price", "ProductName" },
                values: new object[] { 121, 3f, 5, 23.32f, "	Pears - Bosc	" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "InvoiceItems",
                keyColumn: "ID",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "88b37f4b-0e43-4b96-adbc-6163c662ae73");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "c76df0fc-259e-4985-bdc5-74a2be6561e4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "f059e27d-5a99-484b-8e8c-91887f94af3a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "bbe6bf1d-7677-4cdf-96ae-20f3460d4671");
        }
    }
}
