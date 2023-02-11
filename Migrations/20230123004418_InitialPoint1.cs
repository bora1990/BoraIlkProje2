using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BoraIlkProje2.Migrations
{
    /// <inheritdoc />
    public partial class InitialPoint1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 1, 0, "86e05dff-4cc3-4abc-a915-04776be5c5f7", "www.System.Func`1[System.String]@gmail.com", false, false, null, null, null, null, "01671-806868", false, null, false, "Maya" },
                    { 2, 0, "a6eb2645-398f-4e2d-bb02-7e87c462a28a", "www.System.Func`1[System.String]@gmail.com", false, false, null, null, null, null, "01522-485209", false, null, false, "Ariana" },
                    { 3, 0, "0c1f9f05-8773-4448-baa0-626985a9c9b3", "www.System.Func`1[System.String]@gmail.com", false, false, null, null, null, null, "01072-143982", false, null, false, "Sophie" },
                    { 4, 0, "7dfb9122-d446-4ffa-9627-e43d55d9a896", "www.System.Func`1[System.String]@gmail.com", false, false, null, null, null, null, "01344-759420", false, null, false, "Blake" },
                    { 5, 0, "9780c512-c06d-4df7-9079-0257cc80a610", "www.System.Func`1[System.String]@gmail.com", false, false, null, null, null, null, "01938-950796", false, null, false, "Levi" },
                    { 6, 0, "fcb3dc5c-4220-4e42-a0b8-bbd834e0a8b5", "www.System.Func`1[System.String]@gmail.com", false, false, null, null, null, null, "01692-208961", false, null, false, "Eli" },
                    { 7, 0, "00177ff1-5222-45ed-bb47-1d8f3cf94a0f", "www.System.Func`1[System.String]@gmail.com", false, false, null, null, null, null, "01720-389861", false, null, false, "Jason" },
                    { 8, 0, "677811d0-aeaa-4a33-914b-ffbd63995e76", "www.System.Func`1[System.String]@gmail.com", false, false, null, null, null, null, "01257-505253", false, null, false, "Emma" },
                    { 9, 0, "b53d92ee-91b5-43d6-b123-a41f2371181c", "www.System.Func`1[System.String]@gmail.com", false, false, null, null, null, null, "01061-350342", false, null, false, "Juan" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "AppUserId", "CreatedDate", "Ouantity", "Price" },
                values: new object[,]
                {
                    { 1, 0, new DateTime(2020, 6, 10, 1, 13, 44, 434, DateTimeKind.Unspecified).AddTicks(6718), 99, 1339 },
                    { 2, 0, new DateTime(1983, 9, 15, 2, 56, 6, 512, DateTimeKind.Unspecified).AddTicks(767), 63, 1851 },
                    { 3, 0, new DateTime(1990, 5, 5, 1, 37, 44, 631, DateTimeKind.Unspecified).AddTicks(739), 89, 1929 },
                    { 4, 0, new DateTime(2013, 5, 27, 16, 26, 13, 488, DateTimeKind.Unspecified).AddTicks(2926), 61, 1319 },
                    { 5, 0, new DateTime(2011, 6, 11, 12, 57, 54, 732, DateTimeKind.Unspecified).AddTicks(724), 10, 1589 },
                    { 6, 0, new DateTime(1988, 2, 23, 18, 9, 29, 187, DateTimeKind.Unspecified).AddTicks(6007), 66, 1523 },
                    { 7, 0, new DateTime(2006, 9, 20, 20, 50, 36, 44, DateTimeKind.Unspecified).AddTicks(1096), 44, 1370 },
                    { 8, 0, new DateTime(2004, 11, 3, 2, 30, 21, 282, DateTimeKind.Unspecified).AddTicks(5486), 24, 1353 },
                    { 9, 0, new DateTime(2020, 7, 2, 12, 1, 42, 395, DateTimeKind.Unspecified).AddTicks(9440), 95, 1897 }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 9702m, "Mohamed Inc" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 6844m, "Wright LLC" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 8963m, "Haines and Partners" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 8855m, "Hooper CIC" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 5141m, "Williams and Partners" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 5727m, "Schofield Co-Operative" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 5684m, "Joyce Corporation" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 5525m, "Green LLP" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 5849m, "Thomas and Sons" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 9081m, "Abbott Ccc" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 7072m, "Welch and Partners" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 6962m, "Jones Corp." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 9696m, "Roberts PLC" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 5391m, "Power Incorporated" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 5123m, "Lewis Ltd" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 7107m, "Akhtar LP" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 6789m, "Walker Inc" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 9597m, "Swift CIO" });
        }
    }
}
