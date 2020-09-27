using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WatchShop.Migrations
{
    public partial class SeeData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "Logo" },
                values: new object[] { new DateTime(2020, 9, 26, 0, 0, 0, 0, DateTimeKind.Local), "logoCasio.png" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "Logo" },
                values: new object[] { new DateTime(2020, 9, 26, 0, 0, 0, 0, DateTimeKind.Local), "Bulova.png" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "Logo" },
                values: new object[] { new DateTime(2020, 9, 26, 0, 0, 0, 0, DateTimeKind.Local), "GShock.png" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "Logo" },
                values: new object[] { new DateTime(2020, 9, 26, 0, 0, 0, 0, DateTimeKind.Local), "Orient.png" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "Logo" },
                values: new object[] { new DateTime(2020, 9, 26, 0, 0, 0, 0, DateTimeKind.Local), "Seiko.png" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "Logo" },
                values: new object[] { new DateTime(2020, 9, 26, 0, 0, 0, 0, DateTimeKind.Local), "sunrise.png" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateAt", "Logo" },
                values: new object[] { new DateTime(2020, 9, 26, 0, 0, 0, 0, DateTimeKind.Local), "Julius.png" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "Logo" },
                values: new object[] { new DateTime(2020, 9, 26, 0, 0, 0, 0, DateTimeKind.Local), "Pianus.png" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateAt", "Logo" },
                values: new object[] { new DateTime(2020, 9, 26, 0, 0, 0, 0, DateTimeKind.Local), "DW.png" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AvataPath", "CreateAt" },
                values: new object[] { "casio.jpg", new DateTime(2020, 9, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AvataPath", "CreateAt" },
                values: new object[] { "Urgot.jpg", new DateTime(2020, 9, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AvataPath", "CreateAt" },
                values: new object[] { "A.jpg", new DateTime(2020, 9, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AvataPath", "CreateAt" },
                values: new object[] { "images2.jpg", new DateTime(2020, 9, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AvataPath", "CreateAt" },
                values: new object[] { "images1.jpg", new DateTime(2020, 9, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AvataPath", "CreateAt" },
                values: new object[] { "images5.jpg", new DateTime(2020, 9, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AvataPath", "CreateAt" },
                values: new object[] { "images2.jpg", new DateTime(2020, 9, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AvataPath", "CreateAt" },
                values: new object[] { "images1.jpg", new DateTime(2020, 9, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AvataPath", "CreateAt" },
                values: new object[] { "images5.jpg", new DateTime(2020, 9, 26, 0, 0, 0, 0, DateTimeKind.Local) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "Logo" },
                values: new object[] { new DateTime(2020, 9, 22, 0, 0, 0, 0, DateTimeKind.Local), "logoCasio.png" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "Logo" },
                values: new object[] { new DateTime(2020, 9, 22, 0, 0, 0, 0, DateTimeKind.Local), "Bulova.png" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "Logo" },
                values: new object[] { new DateTime(2020, 9, 22, 0, 0, 0, 0, DateTimeKind.Local), "GShock.png" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "Logo" },
                values: new object[] { new DateTime(2020, 9, 22, 0, 0, 0, 0, DateTimeKind.Local), "Orient.png" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "Logo" },
                values: new object[] { new DateTime(2020, 9, 22, 0, 0, 0, 0, DateTimeKind.Local), "Seiko.png" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "Logo" },
                values: new object[] { new DateTime(2020, 9, 22, 0, 0, 0, 0, DateTimeKind.Local), "sunrise.png" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateAt", "Logo" },
                values: new object[] { new DateTime(2020, 9, 22, 0, 0, 0, 0, DateTimeKind.Local), "Julius.png" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "Logo" },
                values: new object[] { new DateTime(2020, 9, 22, 0, 0, 0, 0, DateTimeKind.Local), "Pianus.png" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateAt", "Logo" },
                values: new object[] { new DateTime(2020, 9, 22, 0, 0, 0, 0, DateTimeKind.Local), "DW.png" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AvataPath", "CreateAt" },
                values: new object[] { "casio.jpg", new DateTime(2020, 9, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AvataPath", "CreateAt" },
                values: new object[] { "Urgot.jpg", new DateTime(2020, 9, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AvataPath", "CreateAt" },
                values: new object[] { "A.jpg", new DateTime(2020, 9, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AvataPath", "CreateAt" },
                values: new object[] { "images2.jpg", new DateTime(2020, 9, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AvataPath", "CreateAt" },
                values: new object[] { "images1.jpg", new DateTime(2020, 9, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AvataPath", "CreateAt" },
                values: new object[] { "images5.jpg", new DateTime(2020, 9, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AvataPath", "CreateAt" },
                values: new object[] { "images2.jpg", new DateTime(2020, 9, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AvataPath", "CreateAt" },
                values: new object[] { "images1.jpg", new DateTime(2020, 9, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AvataPath", "CreateAt" },
                values: new object[] { "images5.jpg", new DateTime(2020, 9, 22, 0, 0, 0, 0, DateTimeKind.Local) });
        }
    }
}
