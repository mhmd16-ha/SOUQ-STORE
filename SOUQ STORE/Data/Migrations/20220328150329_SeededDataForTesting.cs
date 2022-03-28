using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SOUQ_STORE.Data.Migrations
{
    public partial class SeededDataForTesting : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CatId", "Description", "Name", "Photo", "Price" },
                values: new object[] { 1, null, null, "Product 1", null, null });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CatId", "Description", "Name", "Photo", "Price" },
                values: new object[] { 2, null, null, "Product 2", null, null });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CatId", "Description", "Name", "Photo", "Price" },
                values: new object[] { 3, null, null, "Product 3", null, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
