using Microsoft.EntityFrameworkCore.Migrations;

namespace WebPage8.Data.Migrations
{
    public partial class SeedComputerCategoryCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[,]
                {
                    { 1, "Acer" },
                    { 2, "Sumsung" },
                    { 3, "Lenovo" },
                    { 4, "Hp" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "City", "Country", "Email", "FirstName", "LastName", "PhoneNumber", "PostalCode", "Street" },
                values: new object[,]
                {
                    { 1, "Goteborg", "Sweden", "za@a.gmail.com", "Wei", "C", "+12345678919", "888", "Möland" },
                    { 2, "Skåne", "Sweden", "ya@a.gmail.com", "Magnus", "I", "+12345678919", "", "aaa" },
                    { 3, "Skövde", "Sweden", "xa@a.gmail.com", "Muzdalifa", "I", "+99345678919", "123", "Frostaliden" },
                    { 4, "Uppsala", "Sweden", "aa@a.gmail.com", "Seong", "Gi-hun", "+33345678919", "123", "bbb" },
                    { 5, "Skövde", "Sweden", "ba@a.gmail.com", "Kang ", "Sae-Byeok", "+12345678919", "345", "Hjo" }
                });

            migrationBuilder.InsertData(
                table: "Computers",
                columns: new[] { "ComputerId", "CategoryId", "HardDisk", "ImageUrl", "Name", "PenAndTouch", "Price", "Processor", "RAM", "SystemType" },
                values: new object[,]
                {
                    { 1, 1, "", "", "A", "No pen and touch input is available for this display", 4500m, "Intel(R) Core(TM) i7-8700K CPU @ 3.7GHz3.70", "32GB", "64-bit operating system, x64-based processor" },
                    { 2, 1, "", "", "B", "No pen and touch input is available for this display", 7000m, "Intel(R) Core(TM) i7-8700K CPU @ 3.7GHz3.70", "32GB", "64-bit operating system, x64-based processor" },
                    { 3, 2, "", "", "C", "No pen and touch input is available for this display", 2450m, "Intel(R) Core(TM) i7-8700K CPU @ 3.7GHz3.70", "32GB", "64-bit operating system, x64-based processor" },
                    { 4, 4, "", "", "D", "No pen and touch input is available for this display", 2000m, "Intel(R) Core(TM) i7-8700K CPU @ 3.7GHz3.70", "32GB", "64-bit operating system, x64-based processor" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Computers",
                keyColumn: "ComputerId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Computers",
                keyColumn: "ComputerId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Computers",
                keyColumn: "ComputerId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Computers",
                keyColumn: "ComputerId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4);
        }
    }
}
