using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 29, 1, 14, 33, 623, DateTimeKind.Local).AddTicks(6863), new DateTime(2023, 11, 29, 1, 14, 33, 623, DateTimeKind.Local).AddTicks(6874), "Black", "System" },
                    { 2, "System", new DateTime(2023, 11, 29, 1, 14, 33, 623, DateTimeKind.Local).AddTicks(6877), new DateTime(2023, 11, 29, 1, 14, 33, 623, DateTimeKind.Local).AddTicks(6878), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 29, 1, 14, 33, 623, DateTimeKind.Local).AddTicks(7213), new DateTime(2023, 11, 29, 1, 14, 33, 623, DateTimeKind.Local).AddTicks(7214), "BMW", "System" },
                    { 2, "System", new DateTime(2023, 11, 29, 1, 14, 33, 623, DateTimeKind.Local).AddTicks(7215), new DateTime(2023, 11, 29, 1, 14, 33, 623, DateTimeKind.Local).AddTicks(7216), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 29, 1, 14, 33, 623, DateTimeKind.Local).AddTicks(7397), new DateTime(2023, 11, 29, 1, 14, 33, 623, DateTimeKind.Local).AddTicks(7398), "3 Series", "System" },
                    { 2, "System", new DateTime(2023, 11, 29, 1, 14, 33, 623, DateTimeKind.Local).AddTicks(7399), new DateTime(2023, 11, 29, 1, 14, 33, 623, DateTimeKind.Local).AddTicks(7400), "X5", "System" },
                    { 3, "System", new DateTime(2023, 11, 29, 1, 14, 33, 623, DateTimeKind.Local).AddTicks(7401), new DateTime(2023, 11, 29, 1, 14, 33, 623, DateTimeKind.Local).AddTicks(7401), "Prius", "System" },
                    { 4, "System", new DateTime(2023, 11, 29, 1, 14, 33, 623, DateTimeKind.Local).AddTicks(7403), new DateTime(2023, 11, 29, 1, 14, 33, 623, DateTimeKind.Local).AddTicks(7403), "Rav4", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
