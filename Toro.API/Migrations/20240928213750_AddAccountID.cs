using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Toro.API.Migrations
{
    /// <inheritdoc />
    public partial class AddAccountID : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AccountId",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: -12,
                columns: new[] { "AccountId", "CreateDate", "Date", "UpdateDate" },
                values: new object[] { 0, new DateTime(2024, 9, 28, 18, 37, 50, 669, DateTimeKind.Local).AddTicks(7730), new DateTime(2024, 9, 28, 18, 37, 50, 669, DateTimeKind.Local).AddTicks(7740), new DateTime(2024, 9, 28, 18, 37, 50, 669, DateTimeKind.Local).AddTicks(7740) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: -11,
                columns: new[] { "AccountId", "CreateDate", "Date", "UpdateDate" },
                values: new object[] { 0, new DateTime(2024, 9, 28, 18, 37, 50, 669, DateTimeKind.Local).AddTicks(7730), new DateTime(2024, 9, 28, 18, 37, 50, 669, DateTimeKind.Local).AddTicks(7730), new DateTime(2024, 9, 28, 18, 37, 50, 669, DateTimeKind.Local).AddTicks(7730) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: -10,
                columns: new[] { "AccountId", "CreateDate", "Date", "UpdateDate" },
                values: new object[] { 0, new DateTime(2024, 9, 28, 18, 37, 50, 669, DateTimeKind.Local).AddTicks(7720), new DateTime(2024, 9, 28, 18, 37, 50, 669, DateTimeKind.Local).AddTicks(7720), new DateTime(2024, 9, 28, 18, 37, 50, 669, DateTimeKind.Local).AddTicks(7720) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: -9,
                columns: new[] { "AccountId", "CreateDate", "Date", "UpdateDate" },
                values: new object[] { 0, new DateTime(2024, 9, 28, 18, 37, 50, 669, DateTimeKind.Local).AddTicks(7710), new DateTime(2024, 9, 28, 18, 37, 50, 669, DateTimeKind.Local).AddTicks(7710), new DateTime(2024, 9, 28, 18, 37, 50, 669, DateTimeKind.Local).AddTicks(7710) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "AccountId", "CreateDate", "Date", "UpdateDate" },
                values: new object[] { 0, new DateTime(2024, 9, 28, 18, 37, 50, 669, DateTimeKind.Local).AddTicks(7700), new DateTime(2024, 9, 28, 18, 37, 50, 669, DateTimeKind.Local).AddTicks(7700), new DateTime(2024, 9, 28, 18, 37, 50, 669, DateTimeKind.Local).AddTicks(7700) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "AccountId", "CreateDate", "Date", "UpdateDate" },
                values: new object[] { 0, new DateTime(2024, 9, 28, 18, 37, 50, 669, DateTimeKind.Local).AddTicks(7690), new DateTime(2024, 9, 28, 18, 37, 50, 669, DateTimeKind.Local).AddTicks(7690), new DateTime(2024, 9, 28, 18, 37, 50, 669, DateTimeKind.Local).AddTicks(7700) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "AccountId", "CreateDate", "Date", "UpdateDate" },
                values: new object[] { 0, new DateTime(2024, 9, 28, 18, 37, 50, 669, DateTimeKind.Local).AddTicks(7680), new DateTime(2024, 9, 28, 18, 37, 50, 669, DateTimeKind.Local).AddTicks(7690), new DateTime(2024, 9, 28, 18, 37, 50, 669, DateTimeKind.Local).AddTicks(7690) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "AccountId", "CreateDate", "Date", "UpdateDate" },
                values: new object[] { 0, new DateTime(2024, 9, 28, 18, 37, 50, 669, DateTimeKind.Local).AddTicks(7680), new DateTime(2024, 9, 28, 18, 37, 50, 669, DateTimeKind.Local).AddTicks(7680), new DateTime(2024, 9, 28, 18, 37, 50, 669, DateTimeKind.Local).AddTicks(7680) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "AccountId", "CreateDate", "Date", "UpdateDate" },
                values: new object[] { 0, new DateTime(2024, 9, 28, 18, 37, 50, 669, DateTimeKind.Local).AddTicks(7670), new DateTime(2024, 9, 28, 18, 37, 50, 669, DateTimeKind.Local).AddTicks(7670), new DateTime(2024, 9, 28, 18, 37, 50, 669, DateTimeKind.Local).AddTicks(7670) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "AccountId", "CreateDate", "Date", "UpdateDate" },
                values: new object[] { 0, new DateTime(2024, 9, 28, 18, 37, 50, 669, DateTimeKind.Local).AddTicks(7660), new DateTime(2024, 9, 28, 18, 37, 50, 669, DateTimeKind.Local).AddTicks(7660), new DateTime(2024, 9, 28, 18, 37, 50, 669, DateTimeKind.Local).AddTicks(7670) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "AccountId", "CreateDate", "Date", "UpdateDate" },
                values: new object[] { 0, new DateTime(2024, 9, 28, 18, 37, 50, 669, DateTimeKind.Local).AddTicks(7650), new DateTime(2024, 9, 28, 18, 37, 50, 669, DateTimeKind.Local).AddTicks(7650), new DateTime(2024, 9, 28, 18, 37, 50, 669, DateTimeKind.Local).AddTicks(7660) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "AccountId", "CreateDate", "Date", "UpdateDate" },
                values: new object[] { 0, new DateTime(2024, 9, 28, 18, 37, 50, 669, DateTimeKind.Local).AddTicks(7570), new DateTime(2024, 9, 28, 18, 37, 50, 669, DateTimeKind.Local).AddTicks(7640), new DateTime(2024, 9, 28, 18, 37, 50, 669, DateTimeKind.Local).AddTicks(7650) });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_AccountId",
                table: "Orders",
                column: "AccountId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Accounts_AccountId",
                table: "Orders",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Accounts_AccountId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_AccountId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "AccountId",
                table: "Orders");

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: -12,
                columns: new[] { "CreateDate", "Date", "UpdateDate" },
                values: new object[] { new DateTime(2024, 9, 28, 12, 10, 48, 129, DateTimeKind.Local).AddTicks(7390), new DateTime(2024, 9, 28, 12, 10, 48, 129, DateTimeKind.Local).AddTicks(7390), new DateTime(2024, 9, 28, 12, 10, 48, 129, DateTimeKind.Local).AddTicks(7390) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: -11,
                columns: new[] { "CreateDate", "Date", "UpdateDate" },
                values: new object[] { new DateTime(2024, 9, 28, 12, 10, 48, 129, DateTimeKind.Local).AddTicks(7390), new DateTime(2024, 9, 28, 12, 10, 48, 129, DateTimeKind.Local).AddTicks(7390), new DateTime(2024, 9, 28, 12, 10, 48, 129, DateTimeKind.Local).AddTicks(7390) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: -10,
                columns: new[] { "CreateDate", "Date", "UpdateDate" },
                values: new object[] { new DateTime(2024, 9, 28, 12, 10, 48, 129, DateTimeKind.Local).AddTicks(7380), new DateTime(2024, 9, 28, 12, 10, 48, 129, DateTimeKind.Local).AddTicks(7380), new DateTime(2024, 9, 28, 12, 10, 48, 129, DateTimeKind.Local).AddTicks(7390) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: -9,
                columns: new[] { "CreateDate", "Date", "UpdateDate" },
                values: new object[] { new DateTime(2024, 9, 28, 12, 10, 48, 129, DateTimeKind.Local).AddTicks(7380), new DateTime(2024, 9, 28, 12, 10, 48, 129, DateTimeKind.Local).AddTicks(7380), new DateTime(2024, 9, 28, 12, 10, 48, 129, DateTimeKind.Local).AddTicks(7380) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "CreateDate", "Date", "UpdateDate" },
                values: new object[] { new DateTime(2024, 9, 28, 12, 10, 48, 129, DateTimeKind.Local).AddTicks(7380), new DateTime(2024, 9, 28, 12, 10, 48, 129, DateTimeKind.Local).AddTicks(7380), new DateTime(2024, 9, 28, 12, 10, 48, 129, DateTimeKind.Local).AddTicks(7380) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "CreateDate", "Date", "UpdateDate" },
                values: new object[] { new DateTime(2024, 9, 28, 12, 10, 48, 129, DateTimeKind.Local).AddTicks(7370), new DateTime(2024, 9, 28, 12, 10, 48, 129, DateTimeKind.Local).AddTicks(7370), new DateTime(2024, 9, 28, 12, 10, 48, 129, DateTimeKind.Local).AddTicks(7380) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "CreateDate", "Date", "UpdateDate" },
                values: new object[] { new DateTime(2024, 9, 28, 12, 10, 48, 129, DateTimeKind.Local).AddTicks(7370), new DateTime(2024, 9, 28, 12, 10, 48, 129, DateTimeKind.Local).AddTicks(7370), new DateTime(2024, 9, 28, 12, 10, 48, 129, DateTimeKind.Local).AddTicks(7370) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "CreateDate", "Date", "UpdateDate" },
                values: new object[] { new DateTime(2024, 9, 28, 12, 10, 48, 129, DateTimeKind.Local).AddTicks(7360), new DateTime(2024, 9, 28, 12, 10, 48, 129, DateTimeKind.Local).AddTicks(7370), new DateTime(2024, 9, 28, 12, 10, 48, 129, DateTimeKind.Local).AddTicks(7370) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "CreateDate", "Date", "UpdateDate" },
                values: new object[] { new DateTime(2024, 9, 28, 12, 10, 48, 129, DateTimeKind.Local).AddTicks(7360), new DateTime(2024, 9, 28, 12, 10, 48, 129, DateTimeKind.Local).AddTicks(7360), new DateTime(2024, 9, 28, 12, 10, 48, 129, DateTimeKind.Local).AddTicks(7360) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CreateDate", "Date", "UpdateDate" },
                values: new object[] { new DateTime(2024, 9, 28, 12, 10, 48, 129, DateTimeKind.Local).AddTicks(7360), new DateTime(2024, 9, 28, 12, 10, 48, 129, DateTimeKind.Local).AddTicks(7360), new DateTime(2024, 9, 28, 12, 10, 48, 129, DateTimeKind.Local).AddTicks(7360) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CreateDate", "Date", "UpdateDate" },
                values: new object[] { new DateTime(2024, 9, 28, 12, 10, 48, 129, DateTimeKind.Local).AddTicks(7350), new DateTime(2024, 9, 28, 12, 10, 48, 129, DateTimeKind.Local).AddTicks(7350), new DateTime(2024, 9, 28, 12, 10, 48, 129, DateTimeKind.Local).AddTicks(7360) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreateDate", "Date", "UpdateDate" },
                values: new object[] { new DateTime(2024, 9, 28, 12, 10, 48, 129, DateTimeKind.Local).AddTicks(7310), new DateTime(2024, 9, 28, 12, 10, 48, 129, DateTimeKind.Local).AddTicks(7350), new DateTime(2024, 9, 28, 12, 10, 48, 129, DateTimeKind.Local).AddTicks(7350) });
        }
    }
}
