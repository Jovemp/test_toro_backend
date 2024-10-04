using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Toro.API.Migrations
{
    /// <inheritdoc />
    public partial class AddFK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: -12,
                columns: new[] { "CreateDate", "Date", "UpdateDate" },
                values: new object[] { new DateTime(2024, 9, 28, 19, 42, 58, 488, DateTimeKind.Local).AddTicks(8160), new DateTime(2024, 9, 28, 19, 42, 58, 488, DateTimeKind.Local).AddTicks(8160), new DateTime(2024, 9, 28, 19, 42, 58, 488, DateTimeKind.Local).AddTicks(8160) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: -11,
                columns: new[] { "CreateDate", "Date", "UpdateDate" },
                values: new object[] { new DateTime(2024, 9, 28, 19, 42, 58, 488, DateTimeKind.Local).AddTicks(8160), new DateTime(2024, 9, 28, 19, 42, 58, 488, DateTimeKind.Local).AddTicks(8160), new DateTime(2024, 9, 28, 19, 42, 58, 488, DateTimeKind.Local).AddTicks(8160) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: -10,
                columns: new[] { "CreateDate", "Date", "UpdateDate" },
                values: new object[] { new DateTime(2024, 9, 28, 19, 42, 58, 488, DateTimeKind.Local).AddTicks(8150), new DateTime(2024, 9, 28, 19, 42, 58, 488, DateTimeKind.Local).AddTicks(8150), new DateTime(2024, 9, 28, 19, 42, 58, 488, DateTimeKind.Local).AddTicks(8150) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: -9,
                columns: new[] { "CreateDate", "Date", "UpdateDate" },
                values: new object[] { new DateTime(2024, 9, 28, 19, 42, 58, 488, DateTimeKind.Local).AddTicks(8130), new DateTime(2024, 9, 28, 19, 42, 58, 488, DateTimeKind.Local).AddTicks(8130), new DateTime(2024, 9, 28, 19, 42, 58, 488, DateTimeKind.Local).AddTicks(8130) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "CreateDate", "Date", "UpdateDate" },
                values: new object[] { new DateTime(2024, 9, 28, 19, 42, 58, 488, DateTimeKind.Local).AddTicks(8130), new DateTime(2024, 9, 28, 19, 42, 58, 488, DateTimeKind.Local).AddTicks(8130), new DateTime(2024, 9, 28, 19, 42, 58, 488, DateTimeKind.Local).AddTicks(8130) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "CreateDate", "Date", "UpdateDate" },
                values: new object[] { new DateTime(2024, 9, 28, 19, 42, 58, 488, DateTimeKind.Local).AddTicks(8120), new DateTime(2024, 9, 28, 19, 42, 58, 488, DateTimeKind.Local).AddTicks(8120), new DateTime(2024, 9, 28, 19, 42, 58, 488, DateTimeKind.Local).AddTicks(8130) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "CreateDate", "Date", "UpdateDate" },
                values: new object[] { new DateTime(2024, 9, 28, 19, 42, 58, 488, DateTimeKind.Local).AddTicks(8120), new DateTime(2024, 9, 28, 19, 42, 58, 488, DateTimeKind.Local).AddTicks(8120), new DateTime(2024, 9, 28, 19, 42, 58, 488, DateTimeKind.Local).AddTicks(8120) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "CreateDate", "Date", "UpdateDate" },
                values: new object[] { new DateTime(2024, 9, 28, 19, 42, 58, 488, DateTimeKind.Local).AddTicks(8120), new DateTime(2024, 9, 28, 19, 42, 58, 488, DateTimeKind.Local).AddTicks(8120), new DateTime(2024, 9, 28, 19, 42, 58, 488, DateTimeKind.Local).AddTicks(8120) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "CreateDate", "Date", "UpdateDate" },
                values: new object[] { new DateTime(2024, 9, 28, 19, 42, 58, 488, DateTimeKind.Local).AddTicks(8110), new DateTime(2024, 9, 28, 19, 42, 58, 488, DateTimeKind.Local).AddTicks(8110), new DateTime(2024, 9, 28, 19, 42, 58, 488, DateTimeKind.Local).AddTicks(8110) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CreateDate", "Date", "UpdateDate" },
                values: new object[] { new DateTime(2024, 9, 28, 19, 42, 58, 488, DateTimeKind.Local).AddTicks(8110), new DateTime(2024, 9, 28, 19, 42, 58, 488, DateTimeKind.Local).AddTicks(8110), new DateTime(2024, 9, 28, 19, 42, 58, 488, DateTimeKind.Local).AddTicks(8110) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CreateDate", "Date", "UpdateDate" },
                values: new object[] { new DateTime(2024, 9, 28, 19, 42, 58, 488, DateTimeKind.Local).AddTicks(8100), new DateTime(2024, 9, 28, 19, 42, 58, 488, DateTimeKind.Local).AddTicks(8110), new DateTime(2024, 9, 28, 19, 42, 58, 488, DateTimeKind.Local).AddTicks(8110) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreateDate", "Date", "UpdateDate" },
                values: new object[] { new DateTime(2024, 9, 28, 19, 42, 58, 488, DateTimeKind.Local).AddTicks(8060), new DateTime(2024, 9, 28, 19, 42, 58, 488, DateTimeKind.Local).AddTicks(8100), new DateTime(2024, 9, 28, 19, 42, 58, 488, DateTimeKind.Local).AddTicks(8100) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: -12,
                columns: new[] { "CreateDate", "Date", "UpdateDate" },
                values: new object[] { new DateTime(2024, 9, 28, 18, 37, 50, 669, DateTimeKind.Local).AddTicks(7730), new DateTime(2024, 9, 28, 18, 37, 50, 669, DateTimeKind.Local).AddTicks(7740), new DateTime(2024, 9, 28, 18, 37, 50, 669, DateTimeKind.Local).AddTicks(7740) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: -11,
                columns: new[] { "CreateDate", "Date", "UpdateDate" },
                values: new object[] { new DateTime(2024, 9, 28, 18, 37, 50, 669, DateTimeKind.Local).AddTicks(7730), new DateTime(2024, 9, 28, 18, 37, 50, 669, DateTimeKind.Local).AddTicks(7730), new DateTime(2024, 9, 28, 18, 37, 50, 669, DateTimeKind.Local).AddTicks(7730) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: -10,
                columns: new[] { "CreateDate", "Date", "UpdateDate" },
                values: new object[] { new DateTime(2024, 9, 28, 18, 37, 50, 669, DateTimeKind.Local).AddTicks(7720), new DateTime(2024, 9, 28, 18, 37, 50, 669, DateTimeKind.Local).AddTicks(7720), new DateTime(2024, 9, 28, 18, 37, 50, 669, DateTimeKind.Local).AddTicks(7720) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: -9,
                columns: new[] { "CreateDate", "Date", "UpdateDate" },
                values: new object[] { new DateTime(2024, 9, 28, 18, 37, 50, 669, DateTimeKind.Local).AddTicks(7710), new DateTime(2024, 9, 28, 18, 37, 50, 669, DateTimeKind.Local).AddTicks(7710), new DateTime(2024, 9, 28, 18, 37, 50, 669, DateTimeKind.Local).AddTicks(7710) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "CreateDate", "Date", "UpdateDate" },
                values: new object[] { new DateTime(2024, 9, 28, 18, 37, 50, 669, DateTimeKind.Local).AddTicks(7700), new DateTime(2024, 9, 28, 18, 37, 50, 669, DateTimeKind.Local).AddTicks(7700), new DateTime(2024, 9, 28, 18, 37, 50, 669, DateTimeKind.Local).AddTicks(7700) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "CreateDate", "Date", "UpdateDate" },
                values: new object[] { new DateTime(2024, 9, 28, 18, 37, 50, 669, DateTimeKind.Local).AddTicks(7690), new DateTime(2024, 9, 28, 18, 37, 50, 669, DateTimeKind.Local).AddTicks(7690), new DateTime(2024, 9, 28, 18, 37, 50, 669, DateTimeKind.Local).AddTicks(7700) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "CreateDate", "Date", "UpdateDate" },
                values: new object[] { new DateTime(2024, 9, 28, 18, 37, 50, 669, DateTimeKind.Local).AddTicks(7680), new DateTime(2024, 9, 28, 18, 37, 50, 669, DateTimeKind.Local).AddTicks(7690), new DateTime(2024, 9, 28, 18, 37, 50, 669, DateTimeKind.Local).AddTicks(7690) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "CreateDate", "Date", "UpdateDate" },
                values: new object[] { new DateTime(2024, 9, 28, 18, 37, 50, 669, DateTimeKind.Local).AddTicks(7680), new DateTime(2024, 9, 28, 18, 37, 50, 669, DateTimeKind.Local).AddTicks(7680), new DateTime(2024, 9, 28, 18, 37, 50, 669, DateTimeKind.Local).AddTicks(7680) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "CreateDate", "Date", "UpdateDate" },
                values: new object[] { new DateTime(2024, 9, 28, 18, 37, 50, 669, DateTimeKind.Local).AddTicks(7670), new DateTime(2024, 9, 28, 18, 37, 50, 669, DateTimeKind.Local).AddTicks(7670), new DateTime(2024, 9, 28, 18, 37, 50, 669, DateTimeKind.Local).AddTicks(7670) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CreateDate", "Date", "UpdateDate" },
                values: new object[] { new DateTime(2024, 9, 28, 18, 37, 50, 669, DateTimeKind.Local).AddTicks(7660), new DateTime(2024, 9, 28, 18, 37, 50, 669, DateTimeKind.Local).AddTicks(7660), new DateTime(2024, 9, 28, 18, 37, 50, 669, DateTimeKind.Local).AddTicks(7670) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CreateDate", "Date", "UpdateDate" },
                values: new object[] { new DateTime(2024, 9, 28, 18, 37, 50, 669, DateTimeKind.Local).AddTicks(7650), new DateTime(2024, 9, 28, 18, 37, 50, 669, DateTimeKind.Local).AddTicks(7650), new DateTime(2024, 9, 28, 18, 37, 50, 669, DateTimeKind.Local).AddTicks(7660) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreateDate", "Date", "UpdateDate" },
                values: new object[] { new DateTime(2024, 9, 28, 18, 37, 50, 669, DateTimeKind.Local).AddTicks(7570), new DateTime(2024, 9, 28, 18, 37, 50, 669, DateTimeKind.Local).AddTicks(7640), new DateTime(2024, 9, 28, 18, 37, 50, 669, DateTimeKind.Local).AddTicks(7650) });
        }
    }
}
