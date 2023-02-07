using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorEcommerce.Server.Migrations
{
    /// <inheritdoc />
    public partial class productseeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "در جای خشک و خنک، دور از تابش مستقیم نور آفتاب نگهداری شود.", "https://shoniz.com/wp-content/uploads/2022/08/%D8%B4%D9%88%D9%86%DB%8C%D8%B2-100-%D9%81%D9%86%D8%AF%D9%82%DB%8C.jpg", 192000m, "شکلات فندقی شونیز 100" },
                    { 2, "در جای خشک و خنک، دور از تابش مستقیم نور آفتاب نگهداری شود.", "https://shoniz.com/wp-content/uploads/2022/08/Shoniz-Gold_Box-15pc-1400.jpg", 340000m, "شونيز طلایی شیری فله" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
