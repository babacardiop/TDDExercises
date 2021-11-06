using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Exercise3.Data.Migrations
{
    public partial class Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Programs_Schools_SchoolId",
                table: "Programs");

            migrationBuilder.AlterColumn<int>(
                name: "SchoolId",
                table: "Programs",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "Id", "Adress", "BirthDate", "FirstName", "LastName", "Sex" },
                values: new object[,]
                {
                    { 1, "", new DateTime(2021, 11, 6, 17, 54, 46, 445, DateTimeKind.Local).AddTicks(2404), "Teacher", "1", "M" },
                    { 2, "", new DateTime(2021, 11, 6, 17, 54, 46, 453, DateTimeKind.Local).AddTicks(2208), "Teacher", "2", "" }
                });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Coding DOJO" });

            migrationBuilder.InsertData(
                table: "Specialities",
                columns: new[] { "Id", "Name", "PrimarySpecialityId", "TeacherId" },
                values: new object[] { 1, "Computer Sciences", null, null });

            migrationBuilder.InsertData(
                table: "Programs",
                columns: new[] { "Id", "Description", "Name", "SchoolId" },
                values: new object[] { 1, "This certificate path will get you through all the basics of web development", "Getting started with Web Development", 1 });

            migrationBuilder.AddForeignKey(
                name: "FK_Programs_Schools_SchoolId",
                table: "Programs",
                column: "SchoolId",
                principalTable: "Schools",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Programs_Schools_SchoolId",
                table: "Programs");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<int>(
                name: "SchoolId",
                table: "Programs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Programs_Schools_SchoolId",
                table: "Programs",
                column: "SchoolId",
                principalTable: "Schools",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
