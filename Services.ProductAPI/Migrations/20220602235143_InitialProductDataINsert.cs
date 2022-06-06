using Microsoft.EntityFrameworkCore.Migrations;

namespace Services.ProductAPI.Migrations
{
    public partial class InitialProductDataINsert : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryName", "Description", "ImageURL", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Appetizer", "Crispy Samosa", "", "Samosa", 15.0 },
                    { 2, "Appetizer", "Delicious Panner Tikka", "", "Panner Tikka", 20.0 },
                    { 3, "Dessert", "Sweet Pie", "", "Sweet Pie", 10.0 },
                    { 4, "Starter", "Pav Bhaji", "", "Pav Bhaji", 15.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);
        }
    }
}
