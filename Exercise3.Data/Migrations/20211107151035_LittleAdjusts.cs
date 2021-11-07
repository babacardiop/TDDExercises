using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Exercise3.Data.Migrations
{
    public partial class LittleAdjusts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "Sex" },
                values: new object[] { new DateTime(2021, 11, 7, 10, 10, 33, 813, DateTimeKind.Local).AddTicks(318), "F" });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BirthDate", "Sex" },
                values: new object[] { new DateTime(2021, 11, 7, 10, 10, 33, 819, DateTimeKind.Local).AddTicks(9940), "M" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "Sex" },
                values: new object[] { new DateTime(2021, 11, 6, 17, 54, 46, 445, DateTimeKind.Local).AddTicks(2404), "M" });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BirthDate", "Sex" },
                values: new object[] { new DateTime(2021, 11, 6, 17, 54, 46, 453, DateTimeKind.Local).AddTicks(2208), "" });
        }
    }
}
