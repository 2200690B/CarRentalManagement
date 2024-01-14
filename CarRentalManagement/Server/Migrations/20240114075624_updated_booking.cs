using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Server.Migrations
{
    /// <inheritdoc />
    public partial class updated_booking : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "47df7068-e83c-4204-b119-df1618709743", "AQAAAAIAAYagAAAAEDIl4hApPhfCfNUG1zeXZIq91zyjLGBEVoqvw/vzJl8hmap6rzvFhE6QHxhIX+jysw==", "ec72e9fa-c306-43fc-93df-8b889303a15b" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 14, 15, 56, 24, 264, DateTimeKind.Local).AddTicks(9869), new DateTime(2024, 1, 14, 15, 56, 24, 264, DateTimeKind.Local).AddTicks(9890) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 14, 15, 56, 24, 264, DateTimeKind.Local).AddTicks(9894), new DateTime(2024, 1, 14, 15, 56, 24, 264, DateTimeKind.Local).AddTicks(9895) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 14, 15, 56, 24, 265, DateTimeKind.Local).AddTicks(609), new DateTime(2024, 1, 14, 15, 56, 24, 265, DateTimeKind.Local).AddTicks(612) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 14, 15, 56, 24, 265, DateTimeKind.Local).AddTicks(615), new DateTime(2024, 1, 14, 15, 56, 24, 265, DateTimeKind.Local).AddTicks(616) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 14, 15, 56, 24, 265, DateTimeKind.Local).AddTicks(1023), new DateTime(2024, 1, 14, 15, 56, 24, 265, DateTimeKind.Local).AddTicks(1026) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 14, 15, 56, 24, 265, DateTimeKind.Local).AddTicks(1030), new DateTime(2024, 1, 14, 15, 56, 24, 265, DateTimeKind.Local).AddTicks(1031) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 14, 15, 56, 24, 265, DateTimeKind.Local).AddTicks(1033), new DateTime(2024, 1, 14, 15, 56, 24, 265, DateTimeKind.Local).AddTicks(1035) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 14, 15, 56, 24, 265, DateTimeKind.Local).AddTicks(1037), new DateTime(2024, 1, 14, 15, 56, 24, 265, DateTimeKind.Local).AddTicks(1038) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9802c2f4-7427-4e54-9b43-9a1961f10fa1", "AQAAAAIAAYagAAAAEDwmK8QzMjq/t4eBP3cufPsPoITB1pTFZeqX7NpmlU082ZrkaDn+HWoqx37cq/lWcw==", "e82b6de0-3044-4af6-aec4-1e407cac948d" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 10, 18, 55, 55, 678, DateTimeKind.Local).AddTicks(8923), new DateTime(2024, 1, 10, 18, 55, 55, 678, DateTimeKind.Local).AddTicks(8937) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 10, 18, 55, 55, 678, DateTimeKind.Local).AddTicks(8940), new DateTime(2024, 1, 10, 18, 55, 55, 678, DateTimeKind.Local).AddTicks(8941) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 10, 18, 55, 55, 678, DateTimeKind.Local).AddTicks(9259), new DateTime(2024, 1, 10, 18, 55, 55, 678, DateTimeKind.Local).AddTicks(9260) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 10, 18, 55, 55, 678, DateTimeKind.Local).AddTicks(9262), new DateTime(2024, 1, 10, 18, 55, 55, 678, DateTimeKind.Local).AddTicks(9262) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 10, 18, 55, 55, 678, DateTimeKind.Local).AddTicks(9447), new DateTime(2024, 1, 10, 18, 55, 55, 678, DateTimeKind.Local).AddTicks(9448) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 10, 18, 55, 55, 678, DateTimeKind.Local).AddTicks(9450), new DateTime(2024, 1, 10, 18, 55, 55, 678, DateTimeKind.Local).AddTicks(9451) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 10, 18, 55, 55, 678, DateTimeKind.Local).AddTicks(9452), new DateTime(2024, 1, 10, 18, 55, 55, 678, DateTimeKind.Local).AddTicks(9453) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 10, 18, 55, 55, 678, DateTimeKind.Local).AddTicks(9454), new DateTime(2024, 1, 10, 18, 55, 55, 678, DateTimeKind.Local).AddTicks(9454) });
        }
    }
}
