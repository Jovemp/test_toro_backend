using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Toro.API.Migrations
{
    /// <inheritdoc />
    public partial class AddTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Balance = table.Column<double>(type: "float", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Bonds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BondAsset = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Index = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tax = table.Column<double>(type: "float", nullable: false),
                    IssuerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UnitPrice = table.Column<double>(type: "float", nullable: false),
                    Stock = table.Column<double>(type: "float", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bonds", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Quantity = table.Column<double>(type: "float", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    BondId = table.Column<int>(type: "int", nullable: false),
                    AccountId = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Orders_Bonds_BondId",
                        column: x => x.BondId,
                        principalTable: "Bonds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "Balance", "ClientId", "CreateDate", "Deleted", "UpdateDate" },
                values: new object[] { -1, 100.0, "12454", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null });

            migrationBuilder.InsertData(
                table: "Bonds",
                columns: new[] { "Id", "BondAsset", "CreateDate", "Deleted", "Index", "IssuerName", "Stock", "Tax", "UnitPrice", "UpdateDate" },
                values: new object[,]
                {
                    { -12, "Debênture", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Selic", "Banco Epsilon", 120.0, 5.7000000000000002, 2100.0, null },
                    { -11, "LCI", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "IPCA", "Banco Zeta", 160.0, 6.0999999999999996, 1900.0, null },
                    { -10, "LCA", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "CDI", "Banco Theta", 140.0, 4.7999999999999998, 1700.0, null },
                    { -9, "CDB", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Selic", "Banco Omega", 220.0, 4.2000000000000002, 1300.0, null },
                    { -8, "CRI", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "IPCA", "Banco Gama", 180.0, 5.9000000000000004, 1100.0, null },
                    { -7, "Debênture", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "CDI", "Banco Delta", 80.0, 7.0, 2000.0, null },
                    { -6, "LCI", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "IPCA", "Banco Beta", 250.0, 5.5, 1800.0, null },
                    { -5, "CDB", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "IPCA", "Banco Alpha", 150.0, 6.2000000000000002, 1000.0, null },
                    { -4, "LCA", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Selic", "Banco Invest", 300.0, 3.7999999999999998, 1200.0, null },
                    { -3, "LCI", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "CDI", "Banco Exemplo", 200.0, 4.5, 1500.0, null },
                    { -2, "LCI", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Pre", "Banco Teste 2", 100.0, 5.0, 2000.0, null },
                    { -1, "CDB", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "IPCA", "Banco Teste", 100.0, 5.0, 1000.0, null }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "AccountId", "BondId", "CreateDate", "Date", "Deleted", "Quantity", "Status", "Type", "UpdateDate" },
                values: new object[,]
                {
                    { -12, null, -12, new DateTime(2024, 9, 28, 19, 50, 21, 870, DateTimeKind.Local).AddTicks(6280), new DateTime(2024, 9, 28, 19, 50, 21, 870, DateTimeKind.Local).AddTicks(6280), false, 120.0, 2, 0, new DateTime(2024, 9, 28, 19, 50, 21, 870, DateTimeKind.Local).AddTicks(6280) },
                    { -11, null, -11, new DateTime(2024, 9, 28, 19, 50, 21, 870, DateTimeKind.Local).AddTicks(6250), new DateTime(2024, 9, 28, 19, 50, 21, 870, DateTimeKind.Local).AddTicks(6260), false, 160.0, 2, 0, new DateTime(2024, 9, 28, 19, 50, 21, 870, DateTimeKind.Local).AddTicks(6260) },
                    { -10, null, -10, new DateTime(2024, 9, 28, 19, 50, 21, 870, DateTimeKind.Local).AddTicks(6250), new DateTime(2024, 9, 28, 19, 50, 21, 870, DateTimeKind.Local).AddTicks(6250), false, 140.0, 2, 0, new DateTime(2024, 9, 28, 19, 50, 21, 870, DateTimeKind.Local).AddTicks(6250) },
                    { -9, null, -9, new DateTime(2024, 9, 28, 19, 50, 21, 870, DateTimeKind.Local).AddTicks(6250), new DateTime(2024, 9, 28, 19, 50, 21, 870, DateTimeKind.Local).AddTicks(6250), false, 220.0, 2, 0, new DateTime(2024, 9, 28, 19, 50, 21, 870, DateTimeKind.Local).AddTicks(6250) },
                    { -8, null, -8, new DateTime(2024, 9, 28, 19, 50, 21, 870, DateTimeKind.Local).AddTicks(6240), new DateTime(2024, 9, 28, 19, 50, 21, 870, DateTimeKind.Local).AddTicks(6240), false, 180.0, 2, 0, new DateTime(2024, 9, 28, 19, 50, 21, 870, DateTimeKind.Local).AddTicks(6250) },
                    { -7, null, -7, new DateTime(2024, 9, 28, 19, 50, 21, 870, DateTimeKind.Local).AddTicks(6240), new DateTime(2024, 9, 28, 19, 50, 21, 870, DateTimeKind.Local).AddTicks(6240), false, 80.0, 2, 0, new DateTime(2024, 9, 28, 19, 50, 21, 870, DateTimeKind.Local).AddTicks(6240) },
                    { -6, null, -6, new DateTime(2024, 9, 28, 19, 50, 21, 870, DateTimeKind.Local).AddTicks(6240), new DateTime(2024, 9, 28, 19, 50, 21, 870, DateTimeKind.Local).AddTicks(6240), false, 250.0, 2, 0, new DateTime(2024, 9, 28, 19, 50, 21, 870, DateTimeKind.Local).AddTicks(6240) },
                    { -5, null, -5, new DateTime(2024, 9, 28, 19, 50, 21, 870, DateTimeKind.Local).AddTicks(6230), new DateTime(2024, 9, 28, 19, 50, 21, 870, DateTimeKind.Local).AddTicks(6230), false, 150.0, 2, 0, new DateTime(2024, 9, 28, 19, 50, 21, 870, DateTimeKind.Local).AddTicks(6230) },
                    { -4, null, -4, new DateTime(2024, 9, 28, 19, 50, 21, 870, DateTimeKind.Local).AddTicks(6230), new DateTime(2024, 9, 28, 19, 50, 21, 870, DateTimeKind.Local).AddTicks(6230), false, 300.0, 2, 0, new DateTime(2024, 9, 28, 19, 50, 21, 870, DateTimeKind.Local).AddTicks(6230) },
                    { -3, null, -3, new DateTime(2024, 9, 28, 19, 50, 21, 870, DateTimeKind.Local).AddTicks(6220), new DateTime(2024, 9, 28, 19, 50, 21, 870, DateTimeKind.Local).AddTicks(6220), false, 200.0, 2, 0, new DateTime(2024, 9, 28, 19, 50, 21, 870, DateTimeKind.Local).AddTicks(6230) },
                    { -2, null, -2, new DateTime(2024, 9, 28, 19, 50, 21, 870, DateTimeKind.Local).AddTicks(6220), new DateTime(2024, 9, 28, 19, 50, 21, 870, DateTimeKind.Local).AddTicks(6220), false, 100.0, 2, 0, new DateTime(2024, 9, 28, 19, 50, 21, 870, DateTimeKind.Local).AddTicks(6220) },
                    { -1, null, -1, new DateTime(2024, 9, 28, 19, 50, 21, 870, DateTimeKind.Local).AddTicks(6090), new DateTime(2024, 9, 28, 19, 50, 21, 870, DateTimeKind.Local).AddTicks(6190), false, 100.0, 2, 0, new DateTime(2024, 9, 28, 19, 50, 21, 870, DateTimeKind.Local).AddTicks(6190) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_AccountId",
                table: "Orders",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_BondId",
                table: "Orders",
                column: "BondId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "Bonds");
        }
    }
}
