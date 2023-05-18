using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class DataSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6c1753de-5be0-48fb-9fa5-416694068808", "AQAAAAIAAYagAAAAEI+oshS77mS4UsUR2UVrfKcV94Q8dGj2atCU1SeD/opYiJGQL8UuRLQfDwfzdeoapA==" });

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
                values: new object[] { new DateTime(2023, 5, 9, 17, 37, 11, 924, DateTimeKind.Local).AddTicks(538), 200000m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
