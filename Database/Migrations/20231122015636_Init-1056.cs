using Microsoft.EntityFrameworkCore.Migrations;
using System;

#nullable disable

namespace Database.Migrations
{
    /// <inheritdoc />
    public partial class Init1056 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Booking",
                columns: new[] { "Id", "IsAviable", "Reservation" },
                values: new object[] { 1, true, new DateTime(2023, 11, 21, 22, 56, 36, 263, DateTimeKind.Local).AddTicks(271) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
