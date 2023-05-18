using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class UpdatePrice2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0bdb7255-c431-4965-b274-8f483c7daab8", "AQAAAAIAAYagAAAAEORNcP1FeGJBcJK3rndKSJQPMJsmaVgC+X4esjw6YBObJXxR1ExN9XpRgsm9gAcCmA==" });

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
                values: new object[] { new DateTime(2023, 5, 11, 9, 29, 14, 192, DateTimeKind.Local).AddTicks(1788), 200000m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f0e21ade-3766-4401-88af-f2364c7a68d0", "AQAAAAIAAYagAAAAEJmckrFw3fF7+0RABh4bniUj750qtUlxHoyiRzyPK9SSZxpmd+nrRCbi/T1nshRd1A==" });

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
                values: new object[] { new DateTime(2023, 5, 11, 9, 24, 53, 613, DateTimeKind.Local).AddTicks(4547), 200000m });
        }
    }
}
