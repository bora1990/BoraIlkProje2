using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BoraIlkProje2.Migrations
{
    /// <inheritdoc />
    public partial class Roles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PhoneNumber", "UserName" },
                values: new object[] { "b677bc4c-71f2-43c9-aa3e-784fdb62014e", "01369-731490", "Liam" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PhoneNumber", "UserName" },
                values: new object[] { "252b95c4-340f-45c6-9a59-8d568f787baa", "01214-932879", "Victoria" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PhoneNumber", "UserName" },
                values: new object[] { "2a7e600a-39c1-4da5-9f4e-0f95d0d86eb3", "01989-652113", "Emily" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PhoneNumber", "UserName" },
                values: new object[] { "d483da6d-4fa6-4641-b5ef-f1805c892943", "01930-867167", "Nicholas" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "PhoneNumber", "UserName" },
                values: new object[] { "c846fbb5-9660-4df5-b1f4-ce51777a75dc", "01660-022878", "Oliver" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "PhoneNumber", "UserName" },
                values: new object[] { "79451f64-a9b2-429a-9e70-d662a4ae7030", "01591-419838", "Aaliyah" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "PhoneNumber", "UserName" },
                values: new object[] { "5f52be9c-7355-4973-9d8a-629246d801f5", "01090-685915", "Mackenzie" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "PhoneNumber", "UserName" },
                values: new object[] { "59546e2c-dd8d-4717-b38e-1ea6b04229d9", "01592-400386", "Hudson" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ConcurrencyStamp", "PhoneNumber", "UserName" },
                values: new object[] { "3560a368-f280-42e2-8ed0-1073cf7d3745", "01582-002775", "Noah" });

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
    }
}
