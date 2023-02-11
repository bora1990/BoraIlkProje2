using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BoraIlkProje2.Migrations
{
    /// <inheritdoc />
    public partial class Roles12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "b9e33134-caaa-4f6a-9313-8eede96ab5f5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "b9d6c597-1832-400e-8d22-0ac48d8952b4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "Name" },
                values: new object[] { "b04cbf75-f177-4bd1-acc8-11c541e4b63a", "Moderator" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PhoneNumber", "UserName" },
                values: new object[] { "cf2b40c8-0d97-4917-a6b9-2596614b5db1", "01145-084943", "Jaxon" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PhoneNumber", "UserName" },
                values: new object[] { "ee96c370-0995-4314-95d0-e5a84453aa8a", "01330-638211", "Emma" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PhoneNumber", "UserName" },
                values: new object[] { "e4f45b88-8e65-409e-a0d5-f79fcfc5c6a2", "01215-224563", "Sarah" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PhoneNumber", "UserName" },
                values: new object[] { "b7f9c46d-5268-4c13-b0e2-0aa0ae6d33a4", "01470-007144", "Cooper" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "PhoneNumber", "UserName" },
                values: new object[] { "200796da-720f-4ddb-add0-6d34d845c30d", "01864-292894", "Logan" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "PhoneNumber", "UserName" },
                values: new object[] { "d4d5f40a-1f2f-4e56-9687-dc7b11147321", "01218-939629", "Lydia" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "PhoneNumber", "UserName" },
                values: new object[] { "c56dfca8-f5d0-42d4-95cd-b1335f2f8b3c", "01012-519965", "Jocelyn" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "PhoneNumber", "UserName" },
                values: new object[] { "16728463-aca1-47dd-8cb7-4c208c3b1883", "01392-613627", "Charlotte" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ConcurrencyStamp", "PhoneNumber", "UserName" },
                values: new object[] { "e147693f-5cc8-4793-ba14-00edaeb13f36", "01083-655089", "Isabella" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 8711m, "Taylor CIO" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 7852m, "Cullen Corporation" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 5301m, "Jackson Incorporated" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 8492m, "Harris Co-Operative" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 9069m, "Barlow CIC" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 9367m, "Mclean Society" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 8058m, "Boyd LLP" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 7255m, "Cassidy Ccc" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 6399m, "Summers Corporation" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "ConcurrencyStamp", "Name" },
                values: new object[] { "6a14bc51-cc42-4128-8a03-59c78fcf201b", "Moderatör" });

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
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 6056m, "Burrows General Partnership" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 5281m, "Hooper Ltd" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 7104m, "Roberts Group" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 5389m, "Rossi Corp." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 6068m, "Osborne Inc" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 9062m, "Lewis CIO" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 8812m, "Baldwin Incorporated" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 9730m, "Summers LLC" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 9185m, "Summers Group" });
        }
    }
}
