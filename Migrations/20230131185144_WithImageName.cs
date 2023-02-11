using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BoraIlkProje2.Migrations
{
    /// <inheritdoc />
    public partial class WithImageName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "21fec45a-9665-49d7-b9e1-a3a8a94104fa");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "bc37b6fe-49b0-463c-9040-4d9c985ae77a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "6a14bc51-cc42-4128-8a03-59c78fcf201b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PhoneNumber", "UserName" },
                values: new object[] { "e283dd03-2789-41aa-8e71-ae0cbd5fc59f", "01762-278155", "David" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PhoneNumber", "UserName" },
                values: new object[] { "c95c3f94-3836-4dd4-859d-af4d81596f62", "01420-533914", "Natalie" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PhoneNumber", "UserName" },
                values: new object[] { "82c7a25b-e76d-4abc-91a9-3326576d2806", "01284-224789", "Faith" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PhoneNumber", "UserName" },
                values: new object[] { "de88f8ea-496b-4fc1-adaf-afed810d10d5", "01899-148194", "Ellie" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "PhoneNumber", "UserName" },
                values: new object[] { "7edf5fef-81b9-4378-8fdb-6fab5f74ca68", "01251-095542", "Tristan" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "PhoneNumber", "UserName" },
                values: new object[] { "3383d9d4-03b1-4068-b7b4-9e94a2df1900", "01748-097771", "Mackenzie" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "PhoneNumber", "UserName" },
                values: new object[] { "43f39bf8-c9f5-4038-80c4-2c4dbcf5c027", "01619-521093", "Joshua" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "PhoneNumber", "UserName" },
                values: new object[] { "26f6361f-2801-4938-b47c-c7706f8d1f11", "01102-398557", "Aaliyah" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ConcurrencyStamp", "PhoneNumber", "UserName" },
                values: new object[] { "5af497fb-91ee-4b94-b193-75f81e7fbdee", "01994-032738", "Luke" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ImageName", "Price", "ProductName" },
                values: new object[] { "1.jpg", 6056m, "Burrows General Partnership" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ImageName", "Price", "ProductName" },
                values: new object[] { "2.jpg", 5281m, "Hooper Ltd" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ImageName", "Price", "ProductName" },
                values: new object[] { "3.jpg", 7104m, "Roberts Group" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ImageName", "Price", "ProductName" },
                values: new object[] { "4.jpg", 5389m, "Rossi Corp." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ImageName", "Price", "ProductName" },
                values: new object[] { "5.jpg", 6068m, "Osborne Inc" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ImageName", "Price", "ProductName" },
                values: new object[] { "6.jpg", 9062m, "Lewis CIO" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ImageName", "Price", "ProductName" },
                values: new object[] { "7.jpg", 8812m, "Baldwin Incorporated" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ImageName", "Price", "ProductName" },
                values: new object[] { "8.jpg", 9730m, "Summers LLC" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ImageName", "Price", "ProductName" },
                values: new object[] { "9.jpg", 9185m, "Summers Group" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "Products");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "AspNetUsers",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "d62f0eae-69d0-4cb7-a869-8092a1b31b67");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "3b4554ae-e0ea-4bd6-b5ae-e4fcba44cda7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "c2241edc-1028-49a9-920c-57c1b56fcc3d");

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

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "AppUserId", "CreatedDate", "Ouantity", "Price" },
                values: new object[,]
                {
                    { 1, 0, new DateTime(2006, 5, 7, 18, 14, 35, 875, DateTimeKind.Unspecified).AddTicks(3540), 82, 1229 },
                    { 2, 0, new DateTime(2021, 2, 20, 18, 33, 37, 48, DateTimeKind.Unspecified).AddTicks(1930), 17, 1397 },
                    { 3, 0, new DateTime(2008, 11, 9, 11, 49, 44, 119, DateTimeKind.Unspecified).AddTicks(3420), 65, 1413 },
                    { 4, 0, new DateTime(1989, 6, 18, 5, 54, 1, 629, DateTimeKind.Unspecified).AddTicks(7542), 97, 1141 },
                    { 5, 0, new DateTime(2008, 4, 10, 19, 18, 35, 245, DateTimeKind.Unspecified).AddTicks(5304), 79, 1652 },
                    { 6, 0, new DateTime(1994, 7, 10, 8, 51, 54, 7, DateTimeKind.Unspecified).AddTicks(3302), 44, 1983 },
                    { 7, 0, new DateTime(2010, 2, 21, 9, 10, 43, 820, DateTimeKind.Unspecified).AddTicks(274), 5, 1478 },
                    { 8, 0, new DateTime(2009, 4, 13, 0, 22, 8, 121, DateTimeKind.Unspecified).AddTicks(7942), 16, 1637 },
                    { 9, 0, new DateTime(1984, 12, 18, 17, 41, 10, 749, DateTimeKind.Unspecified).AddTicks(5910), 91, 1371 }
                });

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
    }
}
