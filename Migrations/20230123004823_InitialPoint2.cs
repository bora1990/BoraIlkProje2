using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BoraIlkProje2.Migrations
{
    /// <inheritdoc />
    public partial class InitialPoint2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "Email", "PhoneNumber", "UserName" },
                values: new object[] { "b677bc4c-71f2-43c9-aa3e-784fdb62014e", null, "01369-731490", "Liam" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "Email", "PhoneNumber", "UserName" },
                values: new object[] { "252b95c4-340f-45c6-9a59-8d568f787baa", null, "01214-932879", "Victoria" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "Email", "PhoneNumber", "UserName" },
                values: new object[] { "2a7e600a-39c1-4da5-9f4e-0f95d0d86eb3", null, "01989-652113", "Emily" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "Email", "PhoneNumber", "UserName" },
                values: new object[] { "d483da6d-4fa6-4641-b5ef-f1805c892943", null, "01930-867167", "Nicholas" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "Email", "PhoneNumber", "UserName" },
                values: new object[] { "c846fbb5-9660-4df5-b1f4-ce51777a75dc", null, "01660-022878", "Oliver" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "Email", "PhoneNumber", "UserName" },
                values: new object[] { "79451f64-a9b2-429a-9e70-d662a4ae7030", null, "01591-419838", "Aaliyah" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "Email", "PhoneNumber", "UserName" },
                values: new object[] { "5f52be9c-7355-4973-9d8a-629246d801f5", null, "01090-685915", "Mackenzie" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "Email", "PhoneNumber", "UserName" },
                values: new object[] { "59546e2c-dd8d-4717-b38e-1ea6b04229d9", null, "01592-400386", "Hudson" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ConcurrencyStamp", "Email", "PhoneNumber", "UserName" },
                values: new object[] { "3560a368-f280-42e2-8ed0-1073cf7d3745", null, "01582-002775", "Noah" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Ouantity", "Price" },
                values: new object[] { new DateTime(2003, 4, 19, 1, 34, 44, 774, DateTimeKind.Unspecified).AddTicks(6734), 73, 1398 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Ouantity", "Price" },
                values: new object[] { new DateTime(2020, 10, 18, 9, 15, 43, 640, DateTimeKind.Unspecified).AddTicks(2368), 41, 1365 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Ouantity", "Price" },
                values: new object[] { new DateTime(1993, 6, 14, 2, 33, 42, 321, DateTimeKind.Unspecified).AddTicks(7297), 7, 1546 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Ouantity", "Price" },
                values: new object[] { new DateTime(1996, 8, 29, 11, 16, 2, 366, DateTimeKind.Unspecified).AddTicks(7625), 68, 1327 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Ouantity", "Price" },
                values: new object[] { new DateTime(1991, 1, 26, 19, 38, 54, 751, DateTimeKind.Unspecified).AddTicks(239), 38, 1582 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Ouantity", "Price" },
                values: new object[] { new DateTime(1975, 11, 5, 0, 40, 13, 143, DateTimeKind.Unspecified).AddTicks(3875), 85, 1547 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Ouantity", "Price" },
                values: new object[] { new DateTime(2019, 5, 18, 10, 12, 35, 262, DateTimeKind.Unspecified).AddTicks(8466), 80, 1406 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Ouantity", "Price" },
                values: new object[] { new DateTime(1994, 8, 10, 3, 8, 8, 630, DateTimeKind.Unspecified).AddTicks(1168), 33, 1272 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Ouantity", "Price" },
                values: new object[] { new DateTime(2016, 6, 24, 7, 6, 18, 475, DateTimeKind.Unspecified).AddTicks(1502), 89, 1533 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 7678m, "Dale PLC" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 9623m, "Mcgrath Cyf" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 5257m, "Williams Corporation" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 7330m, "Mohamed Incorporated" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 7470m, "Carroll and Sons" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 9765m, "Carroll Corporation" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 5271m, "Power PLC" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 9697m, "Abbott PLC" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 6917m, "Haines Ccc" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "Email", "PhoneNumber", "UserName" },
                values: new object[] { "86e05dff-4cc3-4abc-a915-04776be5c5f7", "www.System.Func`1[System.String]@gmail.com", "01671-806868", "Maya" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "Email", "PhoneNumber", "UserName" },
                values: new object[] { "a6eb2645-398f-4e2d-bb02-7e87c462a28a", "www.System.Func`1[System.String]@gmail.com", "01522-485209", "Ariana" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "Email", "PhoneNumber", "UserName" },
                values: new object[] { "0c1f9f05-8773-4448-baa0-626985a9c9b3", "www.System.Func`1[System.String]@gmail.com", "01072-143982", "Sophie" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "Email", "PhoneNumber", "UserName" },
                values: new object[] { "7dfb9122-d446-4ffa-9627-e43d55d9a896", "www.System.Func`1[System.String]@gmail.com", "01344-759420", "Blake" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "Email", "PhoneNumber", "UserName" },
                values: new object[] { "9780c512-c06d-4df7-9079-0257cc80a610", "www.System.Func`1[System.String]@gmail.com", "01938-950796", "Levi" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "Email", "PhoneNumber", "UserName" },
                values: new object[] { "fcb3dc5c-4220-4e42-a0b8-bbd834e0a8b5", "www.System.Func`1[System.String]@gmail.com", "01692-208961", "Eli" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "Email", "PhoneNumber", "UserName" },
                values: new object[] { "00177ff1-5222-45ed-bb47-1d8f3cf94a0f", "www.System.Func`1[System.String]@gmail.com", "01720-389861", "Jason" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "Email", "PhoneNumber", "UserName" },
                values: new object[] { "677811d0-aeaa-4a33-914b-ffbd63995e76", "www.System.Func`1[System.String]@gmail.com", "01257-505253", "Emma" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ConcurrencyStamp", "Email", "PhoneNumber", "UserName" },
                values: new object[] { "b53d92ee-91b5-43d6-b123-a41f2371181c", "www.System.Func`1[System.String]@gmail.com", "01061-350342", "Juan" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Ouantity", "Price" },
                values: new object[] { new DateTime(2020, 6, 10, 1, 13, 44, 434, DateTimeKind.Unspecified).AddTicks(6718), 99, 1339 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Ouantity", "Price" },
                values: new object[] { new DateTime(1983, 9, 15, 2, 56, 6, 512, DateTimeKind.Unspecified).AddTicks(767), 63, 1851 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Ouantity", "Price" },
                values: new object[] { new DateTime(1990, 5, 5, 1, 37, 44, 631, DateTimeKind.Unspecified).AddTicks(739), 89, 1929 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Ouantity", "Price" },
                values: new object[] { new DateTime(2013, 5, 27, 16, 26, 13, 488, DateTimeKind.Unspecified).AddTicks(2926), 61, 1319 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Ouantity", "Price" },
                values: new object[] { new DateTime(2011, 6, 11, 12, 57, 54, 732, DateTimeKind.Unspecified).AddTicks(724), 10, 1589 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Ouantity", "Price" },
                values: new object[] { new DateTime(1988, 2, 23, 18, 9, 29, 187, DateTimeKind.Unspecified).AddTicks(6007), 66, 1523 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Ouantity", "Price" },
                values: new object[] { new DateTime(2006, 9, 20, 20, 50, 36, 44, DateTimeKind.Unspecified).AddTicks(1096), 44, 1370 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Ouantity", "Price" },
                values: new object[] { new DateTime(2004, 11, 3, 2, 30, 21, 282, DateTimeKind.Unspecified).AddTicks(5486), 24, 1353 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Ouantity", "Price" },
                values: new object[] { new DateTime(2020, 7, 2, 12, 1, 42, 395, DateTimeKind.Unspecified).AddTicks(9440), 95, 1897 });

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
    }
}
