using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WatchShop.Migrations
{
    public partial class Addcategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Logo",
                value: "Casio.png");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Logo",
                value: "Bulova.png");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "Logo",
                value: "GShock.png");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "Logo",
                value: "Orient.png");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "Logo",
                value: "Seiko.png");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "Logo",
                value: "sunrise.png");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreateAt", "Description", "Logo", "Name" },
                values: new object[,]
                {
                    { 8, new DateTime(2020, 9, 21, 0, 0, 0, 0, DateTimeKind.Local), "Julius 2019", "Julius.png", "Julius" },
                    { 9, new DateTime(2020, 9, 21, 0, 0, 0, 0, DateTimeKind.Local), "Pianus 456", "Pianus.png", "Pianus" },
                    { 10, new DateTime(2020, 9, 21, 0, 0, 0, 0, DateTimeKind.Local), "DW 104", "DW.png", "DW" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "AvataPath",
                value: "casio.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "AvataPath",
                value: "Urgot.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "AvataPath",
                value: "A.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "AvataPath",
                value: "images2.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "AvataPath",
                value: "images1.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "AvataPath",
                value: "images5.jpg");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AvataPath", "CategoryId", "CreateAt", "Name", "Price" },
                values: new object[] { 8, "images2.jpg", 8, new DateTime(2020, 9, 21, 0, 0, 0, 0, DateTimeKind.Local), "Julius 0012", 4000000.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AvataPath", "CategoryId", "CreateAt", "Name", "Price" },
                values: new object[] { 9, "images1.jpg", 9, new DateTime(2020, 9, 21, 0, 0, 0, 0, DateTimeKind.Local), "Pianus Nữ", 10000000.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AvataPath", "CategoryId", "CreateAt", "Name", "Price" },
                values: new object[] { 10, "images5.jpg", 10, new DateTime(2020, 9, 21, 0, 0, 0, 0, DateTimeKind.Local), "DW Nữ", 10000000.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Logo",
                value: "Casio.png");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Logo",
                value: "Bulova.png");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "Logo",
                value: "GShock.png");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "Logo",
                value: "Orient.png");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "Logo",
                value: "Seiko.png");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "Logo",
                value: "sunrise.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "AvataPath",
                value: "casio.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "AvataPath",
                value: "Urgot.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "AvataPath",
                value: "A.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "AvataPath",
                value: "images2.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "AvataPath",
                value: "images1.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "AvataPath",
                value: "images5.jpg");
        }
    }
}
