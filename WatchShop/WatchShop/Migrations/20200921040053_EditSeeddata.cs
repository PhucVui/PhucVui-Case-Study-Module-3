using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WatchShop.Migrations
{
    public partial class EditSeeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "Logo" },
                values: new object[] { new DateTime(2020, 9, 21, 0, 0, 0, 0, DateTimeKind.Local), "Casio.png" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "Logo" },
                values: new object[] { new DateTime(2020, 9, 21, 0, 0, 0, 0, DateTimeKind.Local), "Bulova.png" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreateAt", "Description", "Logo", "Name" },
                values: new object[,]
                {
                    { 4, new DateTime(2020, 9, 21, 0, 0, 0, 0, DateTimeKind.Local), "GSock 2020", "GShock.png", "GShock" },
                    { 5, new DateTime(2020, 9, 21, 0, 0, 0, 0, DateTimeKind.Local), "Orient 2019", "Orient.png", "Orient" },
                    { 6, new DateTime(2020, 9, 21, 0, 0, 0, 0, DateTimeKind.Local), "Seiko 456", "Seiko.png", "Seiko" },
                    { 7, new DateTime(2020, 9, 21, 0, 0, 0, 0, DateTimeKind.Local), "Sunrise 104", "sunrise.png", "Sunrise" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AvataPath", "CreateAt" },
                values: new object[] { "casio.jpg", new DateTime(2020, 9, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AvataPath", "CreateAt" },
                values: new object[] { "Urgot.jpg", new DateTime(2020, 9, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AvataPath", "CategoryId", "CreateAt", "Name", "Price" },
                values: new object[,]
                {
                    { 4, "A.jpg", 4, new DateTime(2020, 9, 21, 0, 0, 0, 0, DateTimeKind.Local), "GShock 01", 30000000.0 },
                    { 5, "images2.jpg", 5, new DateTime(2020, 9, 21, 0, 0, 0, 0, DateTimeKind.Local), "Orient 0012", 4000000.0 },
                    { 6, "images1.jpg", 6, new DateTime(2020, 9, 21, 0, 0, 0, 0, DateTimeKind.Local), "Seiko Nữ", 10000000.0 },
                    { 7, "images5.jpg", 7, new DateTime(2020, 9, 21, 0, 0, 0, 0, DateTimeKind.Local), "Sunrise Nữ", 10000000.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2020, 9, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2020, 9, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreateAt", "Description", "Name" },
                values: new object[] { 1, new DateTime(2020, 9, 20, 0, 0, 0, 0, DateTimeKind.Local), "danh mục rolex thụy sĩ", "Rolex" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2020, 9, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2020, 9, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreateAt", "Name", "Price" },
                values: new object[] { 1, 1, new DateTime(2020, 9, 20, 0, 0, 0, 0, DateTimeKind.Local), "Rolex 01", 30000000.0 });
        }
    }
}
