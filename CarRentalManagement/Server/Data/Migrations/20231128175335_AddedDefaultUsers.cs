using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "8a26bba9-8882-4a5a-a9ef-3ee32304d4c8", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEOEOmulidZ6eNe9CYZcH12mjQYGsokhMdN7oyCBbv4TNRJKMVHEsjwe4zT8xQTHg1g==", null, false, "290c4141-d7ee-4ef6-ab28-f3acfc48c766", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 29, 1, 53, 35, 94, DateTimeKind.Local).AddTicks(7115), new DateTime(2023, 11, 29, 1, 53, 35, 94, DateTimeKind.Local).AddTicks(7132) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 29, 1, 53, 35, 94, DateTimeKind.Local).AddTicks(7135), new DateTime(2023, 11, 29, 1, 53, 35, 94, DateTimeKind.Local).AddTicks(7135) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 29, 1, 53, 35, 94, DateTimeKind.Local).AddTicks(7434), new DateTime(2023, 11, 29, 1, 53, 35, 94, DateTimeKind.Local).AddTicks(7435) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 29, 1, 53, 35, 94, DateTimeKind.Local).AddTicks(7436), new DateTime(2023, 11, 29, 1, 53, 35, 94, DateTimeKind.Local).AddTicks(7437) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 29, 1, 53, 35, 94, DateTimeKind.Local).AddTicks(7612), new DateTime(2023, 11, 29, 1, 53, 35, 94, DateTimeKind.Local).AddTicks(7612) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 29, 1, 53, 35, 94, DateTimeKind.Local).AddTicks(7614), new DateTime(2023, 11, 29, 1, 53, 35, 94, DateTimeKind.Local).AddTicks(7614) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 29, 1, 53, 35, 94, DateTimeKind.Local).AddTicks(7615), new DateTime(2023, 11, 29, 1, 53, 35, 94, DateTimeKind.Local).AddTicks(7616) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 29, 1, 53, 35, 94, DateTimeKind.Local).AddTicks(7617), new DateTime(2023, 11, 29, 1, 53, 35, 94, DateTimeKind.Local).AddTicks(7617) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 29, 1, 14, 33, 623, DateTimeKind.Local).AddTicks(6863), new DateTime(2023, 11, 29, 1, 14, 33, 623, DateTimeKind.Local).AddTicks(6874) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 29, 1, 14, 33, 623, DateTimeKind.Local).AddTicks(6877), new DateTime(2023, 11, 29, 1, 14, 33, 623, DateTimeKind.Local).AddTicks(6878) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 29, 1, 14, 33, 623, DateTimeKind.Local).AddTicks(7213), new DateTime(2023, 11, 29, 1, 14, 33, 623, DateTimeKind.Local).AddTicks(7214) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 29, 1, 14, 33, 623, DateTimeKind.Local).AddTicks(7215), new DateTime(2023, 11, 29, 1, 14, 33, 623, DateTimeKind.Local).AddTicks(7216) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 29, 1, 14, 33, 623, DateTimeKind.Local).AddTicks(7397), new DateTime(2023, 11, 29, 1, 14, 33, 623, DateTimeKind.Local).AddTicks(7398) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 29, 1, 14, 33, 623, DateTimeKind.Local).AddTicks(7399), new DateTime(2023, 11, 29, 1, 14, 33, 623, DateTimeKind.Local).AddTicks(7400) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 29, 1, 14, 33, 623, DateTimeKind.Local).AddTicks(7401), new DateTime(2023, 11, 29, 1, 14, 33, 623, DateTimeKind.Local).AddTicks(7401) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 29, 1, 14, 33, 623, DateTimeKind.Local).AddTicks(7403), new DateTime(2023, 11, 29, 1, 14, 33, 623, DateTimeKind.Local).AddTicks(7403) });
        }
    }
}
