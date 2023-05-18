using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class AddProductImageTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e6858383-f4a0-4f99-af79-1f8938c6a3ac", "AQAAAAIAAYagAAAAEC9BK+YLFTPnEP5QZM2GqN+h+8PVOIZUi6+9SdSBeGT5LhXcOCVYlso0RoGIeiNL+A==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "IsShowOnHome", "SortOrder" },
                values: new object[] { true, 1 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "IsShowOnHome", "SortOrder" },
                values: new object[] { true, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2023, 5, 9, 17, 33, 21, 773, DateTimeKind.Local).AddTicks(2634), 200000m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6a3234c9-32f0-4301-9863-3fc1233da608", "AQAAAAIAAYagAAAAENnpoY8C2PUkzytjpkDgNWsvo15+hN3oFGiR7hPcUgdvAYfcWR5+KMUXjVdG9/eMnw==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "IsShowOnHome", "SortOrder" },
                values: new object[] { true, 1 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "IsShowOnHome", "SortOrder" },
                values: new object[] { true, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2023, 5, 9, 17, 29, 26, 214, DateTimeKind.Local).AddTicks(226), 200000m });
        }
    }
}
