using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Holloman_Web2Final.Migrations
{
    /// <inheritdoc />
    public partial class AddedAutoGenerate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Order",
                columns: new[] { "OrderId", "CustomerId", "OrderDate", "ProductId" },
                values: new object[] { 1, 1, new DateTime(2024, 12, 1, 14, 14, 10, 412, DateTimeKind.Local).AddTicks(6637), 3 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 1);
        }
    }
}
