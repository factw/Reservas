using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DB.Migrations
{
    /// <inheritdoc />
    public partial class Init1213 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BookingTest",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Reservation = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    IsAviable = table.Column<bool>(type: "NUMBER(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookingTest", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "BookingTest",
                columns: new[] { "Id", "IsAviable", "Reservation" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2023, 11, 21, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, true, new DateTime(2023, 11, 21, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, true, new DateTime(2023, 11, 21, 16, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, true, new DateTime(2023, 11, 22, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, true, new DateTime(2023, 11, 22, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, true, new DateTime(2023, 11, 22, 16, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, true, new DateTime(2023, 11, 23, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, true, new DateTime(2023, 11, 23, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, true, new DateTime(2023, 11, 23, 16, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, true, new DateTime(2023, 11, 24, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, true, new DateTime(2023, 11, 24, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, true, new DateTime(2023, 11, 24, 16, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, true, new DateTime(2023, 11, 27, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, true, new DateTime(2023, 11, 27, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, true, new DateTime(2023, 11, 27, 16, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, true, new DateTime(2023, 11, 28, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, true, new DateTime(2023, 11, 28, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, true, new DateTime(2023, 11, 28, 16, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 19, true, new DateTime(2023, 11, 29, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 20, true, new DateTime(2023, 11, 29, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 21, true, new DateTime(2023, 11, 29, 16, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 22, true, new DateTime(2023, 11, 30, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 23, true, new DateTime(2023, 11, 30, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 24, true, new DateTime(2023, 11, 30, 16, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 25, true, new DateTime(2023, 12, 1, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 26, true, new DateTime(2023, 12, 1, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 27, true, new DateTime(2023, 12, 1, 16, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 28, true, new DateTime(2023, 12, 4, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 29, true, new DateTime(2023, 12, 4, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 30, true, new DateTime(2023, 12, 4, 16, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 31, true, new DateTime(2023, 12, 5, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 32, true, new DateTime(2023, 12, 5, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 33, true, new DateTime(2023, 12, 5, 16, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 34, true, new DateTime(2023, 12, 6, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 35, true, new DateTime(2023, 12, 6, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 36, true, new DateTime(2023, 12, 6, 16, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 37, true, new DateTime(2023, 12, 7, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 38, true, new DateTime(2023, 12, 7, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 39, true, new DateTime(2023, 12, 7, 16, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 40, true, new DateTime(2023, 12, 8, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 41, true, new DateTime(2023, 12, 8, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 42, true, new DateTime(2023, 12, 8, 16, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 43, true, new DateTime(2023, 12, 11, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 44, true, new DateTime(2023, 12, 11, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 45, true, new DateTime(2023, 12, 11, 16, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 46, true, new DateTime(2023, 12, 12, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 47, true, new DateTime(2023, 12, 12, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 48, true, new DateTime(2023, 12, 12, 16, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 49, true, new DateTime(2023, 12, 13, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 50, true, new DateTime(2023, 12, 13, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 51, true, new DateTime(2023, 12, 13, 16, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 52, true, new DateTime(2023, 12, 14, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 53, true, new DateTime(2023, 12, 14, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 54, true, new DateTime(2023, 12, 14, 16, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 55, true, new DateTime(2023, 12, 15, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 56, true, new DateTime(2023, 12, 15, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 57, true, new DateTime(2023, 12, 15, 16, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 58, true, new DateTime(2023, 12, 18, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 59, true, new DateTime(2023, 12, 18, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 60, true, new DateTime(2023, 12, 18, 16, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 61, true, new DateTime(2023, 12, 19, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 62, true, new DateTime(2023, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 63, true, new DateTime(2023, 12, 19, 16, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 64, true, new DateTime(2023, 12, 20, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 65, true, new DateTime(2023, 12, 20, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 66, true, new DateTime(2023, 12, 20, 16, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 67, true, new DateTime(2023, 12, 21, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 68, true, new DateTime(2023, 12, 21, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 69, true, new DateTime(2023, 12, 21, 16, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 70, true, new DateTime(2023, 12, 22, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 71, true, new DateTime(2023, 12, 22, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 72, true, new DateTime(2023, 12, 22, 16, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 73, true, new DateTime(2023, 12, 25, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 74, true, new DateTime(2023, 12, 25, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 75, true, new DateTime(2023, 12, 25, 16, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookingTest");
        }
    }
}
