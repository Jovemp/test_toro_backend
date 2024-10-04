using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Toro.API.Migrations
{
    /// <inheritdoc />
    public partial class AddAccountNull : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Accounts_AccountId",
                table: "Orders");

            migrationBuilder.AlterColumn<int>(
                name: "AccountId",
                table: "Orders",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: -12,
                columns: new[] { "AccountId", "CreateDate", "Date", "UpdateDate" },
                values: new object[] { null, new DateTime(2024, 9, 28, 19, 48, 7, 121, DateTimeKind.Local).AddTicks(2140), new DateTime(2024, 9, 28, 19, 48, 7, 121, DateTimeKind.Local).AddTicks(2140), new DateTime(2024, 9, 28, 19, 48, 7, 121, DateTimeKind.Local).AddTicks(2140) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: -11,
                columns: new[] { "AccountId", "CreateDate", "Date", "UpdateDate" },
                values: new object[] { null, new DateTime(2024, 9, 28, 19, 48, 7, 121, DateTimeKind.Local).AddTicks(2130), new DateTime(2024, 9, 28, 19, 48, 7, 121, DateTimeKind.Local).AddTicks(2140), new DateTime(2024, 9, 28, 19, 48, 7, 121, DateTimeKind.Local).AddTicks(2140) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: -10,
                columns: new[] { "AccountId", "CreateDate", "Date", "UpdateDate" },
                values: new object[] { null, new DateTime(2024, 9, 28, 19, 48, 7, 121, DateTimeKind.Local).AddTicks(2130), new DateTime(2024, 9, 28, 19, 48, 7, 121, DateTimeKind.Local).AddTicks(2130), new DateTime(2024, 9, 28, 19, 48, 7, 121, DateTimeKind.Local).AddTicks(2130) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: -9,
                columns: new[] { "AccountId", "CreateDate", "Date", "UpdateDate" },
                values: new object[] { null, new DateTime(2024, 9, 28, 19, 48, 7, 121, DateTimeKind.Local).AddTicks(2130), new DateTime(2024, 9, 28, 19, 48, 7, 121, DateTimeKind.Local).AddTicks(2130), new DateTime(2024, 9, 28, 19, 48, 7, 121, DateTimeKind.Local).AddTicks(2130) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "AccountId", "CreateDate", "Date", "UpdateDate" },
                values: new object[] { null, new DateTime(2024, 9, 28, 19, 48, 7, 121, DateTimeKind.Local).AddTicks(2120), new DateTime(2024, 9, 28, 19, 48, 7, 121, DateTimeKind.Local).AddTicks(2120), new DateTime(2024, 9, 28, 19, 48, 7, 121, DateTimeKind.Local).AddTicks(2120) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "AccountId", "CreateDate", "Date", "UpdateDate" },
                values: new object[] { null, new DateTime(2024, 9, 28, 19, 48, 7, 121, DateTimeKind.Local).AddTicks(2120), new DateTime(2024, 9, 28, 19, 48, 7, 121, DateTimeKind.Local).AddTicks(2120), new DateTime(2024, 9, 28, 19, 48, 7, 121, DateTimeKind.Local).AddTicks(2120) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "AccountId", "CreateDate", "Date", "UpdateDate" },
                values: new object[] { null, new DateTime(2024, 9, 28, 19, 48, 7, 121, DateTimeKind.Local).AddTicks(2120), new DateTime(2024, 9, 28, 19, 48, 7, 121, DateTimeKind.Local).AddTicks(2120), new DateTime(2024, 9, 28, 19, 48, 7, 121, DateTimeKind.Local).AddTicks(2120) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "AccountId", "CreateDate", "Date", "UpdateDate" },
                values: new object[] { null, new DateTime(2024, 9, 28, 19, 48, 7, 121, DateTimeKind.Local).AddTicks(2110), new DateTime(2024, 9, 28, 19, 48, 7, 121, DateTimeKind.Local).AddTicks(2110), new DateTime(2024, 9, 28, 19, 48, 7, 121, DateTimeKind.Local).AddTicks(2110) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "AccountId", "CreateDate", "Date", "UpdateDate" },
                values: new object[] { null, new DateTime(2024, 9, 28, 19, 48, 7, 121, DateTimeKind.Local).AddTicks(2110), new DateTime(2024, 9, 28, 19, 48, 7, 121, DateTimeKind.Local).AddTicks(2110), new DateTime(2024, 9, 28, 19, 48, 7, 121, DateTimeKind.Local).AddTicks(2110) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "AccountId", "CreateDate", "Date", "UpdateDate" },
                values: new object[] { null, new DateTime(2024, 9, 28, 19, 48, 7, 121, DateTimeKind.Local).AddTicks(2100), new DateTime(2024, 9, 28, 19, 48, 7, 121, DateTimeKind.Local).AddTicks(2110), new DateTime(2024, 9, 28, 19, 48, 7, 121, DateTimeKind.Local).AddTicks(2110) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "AccountId", "CreateDate", "Date", "UpdateDate" },
                values: new object[] { null, new DateTime(2024, 9, 28, 19, 48, 7, 121, DateTimeKind.Local).AddTicks(2100), new DateTime(2024, 9, 28, 19, 48, 7, 121, DateTimeKind.Local).AddTicks(2100), new DateTime(2024, 9, 28, 19, 48, 7, 121, DateTimeKind.Local).AddTicks(2100) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "AccountId", "CreateDate", "Date", "UpdateDate" },
                values: new object[] { null, new DateTime(2024, 9, 28, 19, 48, 7, 121, DateTimeKind.Local).AddTicks(2060), new DateTime(2024, 9, 28, 19, 48, 7, 121, DateTimeKind.Local).AddTicks(2090), new DateTime(2024, 9, 28, 19, 48, 7, 121, DateTimeKind.Local).AddTicks(2090) });

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Accounts_AccountId",
                table: "Orders",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Accounts_AccountId",
                table: "Orders");

            migrationBuilder.AlterColumn<int>(
                name: "AccountId",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: -12,
                columns: new[] { "AccountId", "CreateDate", "Date", "UpdateDate" },
                values: new object[] { 0, new DateTime(2024, 9, 28, 19, 42, 58, 488, DateTimeKind.Local).AddTicks(8160), new DateTime(2024, 9, 28, 19, 42, 58, 488, DateTimeKind.Local).AddTicks(8160), new DateTime(2024, 9, 28, 19, 42, 58, 488, DateTimeKind.Local).AddTicks(8160) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: -11,
                columns: new[] { "AccountId", "CreateDate", "Date", "UpdateDate" },
                values: new object[] { 0, new DateTime(2024, 9, 28, 19, 42, 58, 488, DateTimeKind.Local).AddTicks(8160), new DateTime(2024, 9, 28, 19, 42, 58, 488, DateTimeKind.Local).AddTicks(8160), new DateTime(2024, 9, 28, 19, 42, 58, 488, DateTimeKind.Local).AddTicks(8160) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: -10,
                columns: new[] { "AccountId", "CreateDate", "Date", "UpdateDate" },
                values: new object[] { 0, new DateTime(2024, 9, 28, 19, 42, 58, 488, DateTimeKind.Local).AddTicks(8150), new DateTime(2024, 9, 28, 19, 42, 58, 488, DateTimeKind.Local).AddTicks(8150), new DateTime(2024, 9, 28, 19, 42, 58, 488, DateTimeKind.Local).AddTicks(8150) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: -9,
                columns: new[] { "AccountId", "CreateDate", "Date", "UpdateDate" },
                values: new object[] { 0, new DateTime(2024, 9, 28, 19, 42, 58, 488, DateTimeKind.Local).AddTicks(8130), new DateTime(2024, 9, 28, 19, 42, 58, 488, DateTimeKind.Local).AddTicks(8130), new DateTime(2024, 9, 28, 19, 42, 58, 488, DateTimeKind.Local).AddTicks(8130) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "AccountId", "CreateDate", "Date", "UpdateDate" },
                values: new object[] { 0, new DateTime(2024, 9, 28, 19, 42, 58, 488, DateTimeKind.Local).AddTicks(8130), new DateTime(2024, 9, 28, 19, 42, 58, 488, DateTimeKind.Local).AddTicks(8130), new DateTime(2024, 9, 28, 19, 42, 58, 488, DateTimeKind.Local).AddTicks(8130) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "AccountId", "CreateDate", "Date", "UpdateDate" },
                values: new object[] { 0, new DateTime(2024, 9, 28, 19, 42, 58, 488, DateTimeKind.Local).AddTicks(8120), new DateTime(2024, 9, 28, 19, 42, 58, 488, DateTimeKind.Local).AddTicks(8120), new DateTime(2024, 9, 28, 19, 42, 58, 488, DateTimeKind.Local).AddTicks(8130) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "AccountId", "CreateDate", "Date", "UpdateDate" },
                values: new object[] { 0, new DateTime(2024, 9, 28, 19, 42, 58, 488, DateTimeKind.Local).AddTicks(8120), new DateTime(2024, 9, 28, 19, 42, 58, 488, DateTimeKind.Local).AddTicks(8120), new DateTime(2024, 9, 28, 19, 42, 58, 488, DateTimeKind.Local).AddTicks(8120) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "AccountId", "CreateDate", "Date", "UpdateDate" },
                values: new object[] { 0, new DateTime(2024, 9, 28, 19, 42, 58, 488, DateTimeKind.Local).AddTicks(8120), new DateTime(2024, 9, 28, 19, 42, 58, 488, DateTimeKind.Local).AddTicks(8120), new DateTime(2024, 9, 28, 19, 42, 58, 488, DateTimeKind.Local).AddTicks(8120) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "AccountId", "CreateDate", "Date", "UpdateDate" },
                values: new object[] { 0, new DateTime(2024, 9, 28, 19, 42, 58, 488, DateTimeKind.Local).AddTicks(8110), new DateTime(2024, 9, 28, 19, 42, 58, 488, DateTimeKind.Local).AddTicks(8110), new DateTime(2024, 9, 28, 19, 42, 58, 488, DateTimeKind.Local).AddTicks(8110) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "AccountId", "CreateDate", "Date", "UpdateDate" },
                values: new object[] { 0, new DateTime(2024, 9, 28, 19, 42, 58, 488, DateTimeKind.Local).AddTicks(8110), new DateTime(2024, 9, 28, 19, 42, 58, 488, DateTimeKind.Local).AddTicks(8110), new DateTime(2024, 9, 28, 19, 42, 58, 488, DateTimeKind.Local).AddTicks(8110) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "AccountId", "CreateDate", "Date", "UpdateDate" },
                values: new object[] { 0, new DateTime(2024, 9, 28, 19, 42, 58, 488, DateTimeKind.Local).AddTicks(8100), new DateTime(2024, 9, 28, 19, 42, 58, 488, DateTimeKind.Local).AddTicks(8110), new DateTime(2024, 9, 28, 19, 42, 58, 488, DateTimeKind.Local).AddTicks(8110) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "AccountId", "CreateDate", "Date", "UpdateDate" },
                values: new object[] { 0, new DateTime(2024, 9, 28, 19, 42, 58, 488, DateTimeKind.Local).AddTicks(8060), new DateTime(2024, 9, 28, 19, 42, 58, 488, DateTimeKind.Local).AddTicks(8100), new DateTime(2024, 9, 28, 19, 42, 58, 488, DateTimeKind.Local).AddTicks(8100) });

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Accounts_AccountId",
                table: "Orders",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
