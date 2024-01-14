using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Server.Migrations
{
    /// <inheritdoc />
    public partial class updatedb_booking : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateIn",
                table: "Bookings",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateIn",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8932a82a-ae73-4f56-85a7-b3d218f1688e", "AQAAAAIAAYagAAAAEOdXWbE8jzia/xp3/5AGqMwG5aS+Sacx0R3+z2r7Xq1zp+MFEdlpxUGrRu60iSabGw==", "eadd9134-70c5-4432-9336-e3caa92408c3" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 10, 17, 50, 40, 480, DateTimeKind.Local).AddTicks(7235), new DateTime(2024, 1, 10, 17, 50, 40, 480, DateTimeKind.Local).AddTicks(7249) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 10, 17, 50, 40, 480, DateTimeKind.Local).AddTicks(7251), new DateTime(2024, 1, 10, 17, 50, 40, 480, DateTimeKind.Local).AddTicks(7251) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 10, 17, 50, 40, 480, DateTimeKind.Local).AddTicks(7571), new DateTime(2024, 1, 10, 17, 50, 40, 480, DateTimeKind.Local).AddTicks(7571) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 10, 17, 50, 40, 480, DateTimeKind.Local).AddTicks(7573), new DateTime(2024, 1, 10, 17, 50, 40, 480, DateTimeKind.Local).AddTicks(7574) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 10, 17, 50, 40, 480, DateTimeKind.Local).AddTicks(7778), new DateTime(2024, 1, 10, 17, 50, 40, 480, DateTimeKind.Local).AddTicks(7779) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 10, 17, 50, 40, 480, DateTimeKind.Local).AddTicks(7781), new DateTime(2024, 1, 10, 17, 50, 40, 480, DateTimeKind.Local).AddTicks(7782) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 10, 17, 50, 40, 480, DateTimeKind.Local).AddTicks(7783), new DateTime(2024, 1, 10, 17, 50, 40, 480, DateTimeKind.Local).AddTicks(7783) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 10, 17, 50, 40, 480, DateTimeKind.Local).AddTicks(7784), new DateTime(2024, 1, 10, 17, 50, 40, 480, DateTimeKind.Local).AddTicks(7785) });
        }
    }
}
