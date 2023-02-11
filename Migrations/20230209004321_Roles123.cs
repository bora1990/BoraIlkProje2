using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BoraIlkProje2.Migrations
{
    /// <inheritdoc />
    public partial class Roles123 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "Name" },
                values: new object[] { "a51e1684-a418-4219-b94d-2ec59f25efe1", "admin" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "Name" },
                values: new object[] { "ebfda775-6081-40c5-ad5d-e1657945060d", "editor" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "Name" },
                values: new object[] { "a5db1325-d87c-4543-a0ec-9199ba58ce3e", "moderator" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PhoneNumber", "UserName" },
                values: new object[] { "7555a266-0c5f-4f30-94cb-58abb308348c", "01562-379826", "Alyssa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PhoneNumber", "UserName" },
                values: new object[] { "16d4f1ff-f794-4de3-b1d3-a5154fc9905b", "01992-788609", "Arianna" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PhoneNumber", "UserName" },
                values: new object[] { "ba65c94c-995d-4823-ad9e-c1ebd75a090e", "01769-428382", "Aubree" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PhoneNumber", "UserName" },
                values: new object[] { "5f397a3b-a777-41e9-b3aa-f8cdd62f1c0e", "01976-934879", "Adrian" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "PhoneNumber", "UserName" },
                values: new object[] { "50d3035c-4b34-4036-8685-ec438e96453e", "01551-992402", "Savannah" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "PhoneNumber", "UserName" },
                values: new object[] { "2bc4bf4c-c551-4d6c-888f-3e6dcc26b8f7", "01321-030241", "Isaac" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "PhoneNumber", "UserName" },
                values: new object[] { "8351b5f2-973f-424d-98f1-848d796491e2", "01228-101199", "Sarah" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "PhoneNumber", "UserName" },
                values: new object[] { "01b2589c-e8b3-4763-b759-87ea1505c1e2", "01513-281553", "Chloe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ConcurrencyStamp", "PhoneNumber", "UserName" },
                values: new object[] { "238730bc-fe3d-4263-b32e-7f0cfe4fdb95", "01892-400001", "Levi" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 6093m, "Dale LLP" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 6936m, "Taylor Co-Operative" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 9835m, "Mcgregor General Partnership" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 7756m, "Brown and Partners" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 9963m, "Whelan Society" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 6974m, "Thornton and Partners" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 6526m, "Cullen and Partners" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 7171m, "Thompson General Partnership" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 5914m, "Leach LLP" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "Name" },
                values: new object[] { "b9e33134-caaa-4f6a-9313-8eede96ab5f5", "Admin" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "Name" },
                values: new object[] { "b9d6c597-1832-400e-8d22-0ac48d8952b4", "Editor" });

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
    }
}
