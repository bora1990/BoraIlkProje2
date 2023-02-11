using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BoraIlkProje2.Migrations
{
    /// <inheritdoc />
    public partial class Roles1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1, "d62f0eae-69d0-4cb7-a869-8092a1b31b67", "Admin", null },
                    { 2, "3b4554ae-e0ea-4bd6-b5ae-e4fcba44cda7", "Editor", null },
                    { 3, "c2241edc-1028-49a9-920c-57c1b56fcc3d", "Moderatör", null }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PhoneNumber", "UserName" },
                values: new object[] { "0eeb14be-b30f-4ea2-b365-aefb580177fd", "01972-649656", "Brayden" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PhoneNumber", "UserName" },
                values: new object[] { "491725f4-dc44-4483-a12a-b61420c88e45", "01333-592332", "Landon" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PhoneNumber", "UserName" },
                values: new object[] { "addf2ce0-03c1-4470-a501-3d024c959df3", "01119-032070", "David" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PhoneNumber", "UserName" },
                values: new object[] { "db95461f-48c0-46fa-8647-666c7994d03f", "01747-782950", "Lucas" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "PhoneNumber", "UserName" },
                values: new object[] { "a625b3e5-b53f-4103-b50e-64f47e2abe6a", "01720-995117", "Julian" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "PhoneNumber", "UserName" },
                values: new object[] { "4762c6c7-90f4-49bb-a4cf-2e5578ad6c3f", "01319-687823", "Harper" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "PhoneNumber", "UserName" },
                values: new object[] { "edecc5f9-2b8b-449c-9c16-8d68eaab31ea", "01942-812898", "Naomi" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "PhoneNumber", "UserName" },
                values: new object[] { "58cba3bb-20eb-4d5a-b393-fba042df8c82", "01905-762636", "Julia" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ConcurrencyStamp", "PhoneNumber", "UserName" },
                values: new object[] { "950a9214-61e7-4d64-bb14-6eb55ce200a2", "01605-851511", "Hailey" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Ouantity", "Price" },
                values: new object[] { new DateTime(2006, 5, 7, 18, 14, 35, 875, DateTimeKind.Unspecified).AddTicks(3540), 82, 1229 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Ouantity", "Price" },
                values: new object[] { new DateTime(2021, 2, 20, 18, 33, 37, 48, DateTimeKind.Unspecified).AddTicks(1930), 17, 1397 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Ouantity", "Price" },
                values: new object[] { new DateTime(2008, 11, 9, 11, 49, 44, 119, DateTimeKind.Unspecified).AddTicks(3420), 65, 1413 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Ouantity", "Price" },
                values: new object[] { new DateTime(1989, 6, 18, 5, 54, 1, 629, DateTimeKind.Unspecified).AddTicks(7542), 97, 1141 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Ouantity", "Price" },
                values: new object[] { new DateTime(2008, 4, 10, 19, 18, 35, 245, DateTimeKind.Unspecified).AddTicks(5304), 79, 1652 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Ouantity", "Price" },
                values: new object[] { new DateTime(1994, 7, 10, 8, 51, 54, 7, DateTimeKind.Unspecified).AddTicks(3302), 44, 1983 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Ouantity", "Price" },
                values: new object[] { new DateTime(2010, 2, 21, 9, 10, 43, 820, DateTimeKind.Unspecified).AddTicks(274), 5, 1478 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Ouantity", "Price" },
                values: new object[] { new DateTime(2009, 4, 13, 0, 22, 8, 121, DateTimeKind.Unspecified).AddTicks(7942), 16, 1637 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Ouantity", "Price" },
                values: new object[] { new DateTime(1984, 12, 18, 17, 41, 10, 749, DateTimeKind.Unspecified).AddTicks(5910), 91, 1371 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 9149m, "Abbott Incorporated" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 8896m, "Akhtar General Partnership" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 6779m, "Weaver Ccc" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 8975m, "Power CIO" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 6967m, "Harris Cyf" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 7652m, "Sinclair General Partnership" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 8958m, "Whittaker PLC" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 5964m, "Brown CIO" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 6617m, "Johnson Ltd" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PhoneNumber", "UserName" },
                values: new object[] { "a5de80c4-3b13-4ef6-9314-5c28d1c771ab", "01253-943073", "Thomas" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PhoneNumber", "UserName" },
                values: new object[] { "36e7e9f6-4014-4ed8-b1b1-b9d105230e4d", "01642-279328", "Josiah" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PhoneNumber", "UserName" },
                values: new object[] { "60360243-506d-4b9d-89b0-540b97af9e80", "01839-461557", "Connor" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PhoneNumber", "UserName" },
                values: new object[] { "6963dc70-3d91-4103-bf3c-cdcd49bd3a1b", "01229-041462", "Ava" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "PhoneNumber", "UserName" },
                values: new object[] { "0747590a-fec6-40c2-a20a-303d62bfd926", "01295-261611", "Brandon" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "PhoneNumber", "UserName" },
                values: new object[] { "7397f022-92b2-4d3d-9680-ddc26680d867", "01051-013689", "Carter" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "PhoneNumber", "UserName" },
                values: new object[] { "0fe30c81-1bbd-4542-bd85-8fb00a2cc97a", "01267-894495", "Sophia" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "PhoneNumber", "UserName" },
                values: new object[] { "34c07315-31ac-4cbf-8a16-b6f77bf43a73", "01946-077280", "Josiah" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ConcurrencyStamp", "PhoneNumber", "UserName" },
                values: new object[] { "d9a20c47-578f-440a-b861-149f106e8ef4", "01740-893556", "Brooklyn" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Ouantity", "Price" },
                values: new object[] { new DateTime(2020, 10, 10, 11, 25, 16, 0, DateTimeKind.Unspecified).AddTicks(8758), 59, 1729 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Ouantity", "Price" },
                values: new object[] { new DateTime(1978, 8, 15, 1, 45, 51, 649, DateTimeKind.Unspecified).AddTicks(5176), 1, 1392 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Ouantity", "Price" },
                values: new object[] { new DateTime(2001, 5, 20, 6, 11, 55, 86, DateTimeKind.Unspecified).AddTicks(6744), 26, 1615 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Ouantity", "Price" },
                values: new object[] { new DateTime(2017, 8, 7, 7, 16, 31, 827, DateTimeKind.Unspecified).AddTicks(8994), 70, 1828 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Ouantity", "Price" },
                values: new object[] { new DateTime(1984, 1, 29, 16, 9, 28, 888, DateTimeKind.Unspecified).AddTicks(710), 82, 1017 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Ouantity", "Price" },
                values: new object[] { new DateTime(2007, 5, 25, 14, 49, 50, 257, DateTimeKind.Unspecified).AddTicks(8038), 17, 1991 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Ouantity", "Price" },
                values: new object[] { new DateTime(2012, 10, 9, 17, 12, 57, 90, DateTimeKind.Unspecified).AddTicks(3456), 61, 1188 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Ouantity", "Price" },
                values: new object[] { new DateTime(1977, 3, 5, 20, 45, 15, 62, DateTimeKind.Unspecified).AddTicks(9552), 82, 1997 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Ouantity", "Price" },
                values: new object[] { new DateTime(1997, 6, 30, 13, 2, 18, 916, DateTimeKind.Unspecified).AddTicks(4138), 9, 1912 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 8393m, "Nash CIO" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 6953m, "Jones Ltd" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 9559m, "Walker Ccc" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 6225m, "Osborne Cyf" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 7999m, "Davies Co-Operative" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 6797m, "Naylor General Partnership" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 8737m, "Cullen and Sons" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 7892m, "White Incorporated" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 5470m, "Schofield Cyf" });
        }
    }
}
