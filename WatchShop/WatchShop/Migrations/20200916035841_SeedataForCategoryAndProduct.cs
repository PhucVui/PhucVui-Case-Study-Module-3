using Microsoft.EntityFrameworkCore.Migrations;

namespace WatchShop.Migrations
{
    public partial class SeedataForCategoryAndProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 1, "danh mục rolex thụy sĩ", "Rolex" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 2, "Casio việt Nam", "Casio" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 3, "Bulova Ý", "Bulova" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AvataPath", "CategoryId", "Name", "Price" },
                values: new object[] { 1, null, 1, "Rolex 01", 30000000.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AvataPath", "CategoryId", "Name", "Price" },
                values: new object[] { 2, null, 2, "Casio 0012", 4000000.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AvataPath", "CategoryId", "Name", "Price" },
                values: new object[] { 3, null, 3, "Bulova Nữ", 10000000.0 });
        }

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

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 200);
        }
    }
}
