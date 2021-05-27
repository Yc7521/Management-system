using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace 管理系统.Migrations
{
    public partial class u1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BuyMerchandiseList",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    BillingDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Storehouse = table.Column<string>(type: "TEXT", nullable: false),
                    ExchangeCompany = table.Column<string>(type: "TEXT", nullable: false),
                    Manager = table.Column<string>(type: "TEXT", nullable: false),
                    Confirm = table.Column<bool>(type: "INTEGER", nullable: false),
                    ConfirmDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ArrivalDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Contract = table.Column<decimal>(type: "TEXT", nullable: false),
                    Prepaid = table.Column<decimal>(type: "TEXT", nullable: false),
                    Operator = table.Column<string>(type: "TEXT", nullable: false),
                    Explain = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuyMerchandiseList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Merchandise",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Company = table.Column<string>(type: "TEXT", nullable: false),
                    StockNum = table.Column<int>(type: "INTEGER", nullable: false),
                    FinancialStock = table.Column<int>(type: "INTEGER", nullable: false),
                    PickingNum = table.Column<int>(type: "INTEGER", nullable: false),
                    OrderNum = table.Column<int>(type: "INTEGER", nullable: false),
                    PinableNum = table.Column<int>(type: "INTEGER", nullable: false),
                    CostPrice = table.Column<decimal>(type: "TEXT", nullable: false),
                    StockAmount = table.Column<decimal>(type: "TEXT", nullable: false),
                    Total = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Merchandise", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OutMerchandiseList",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Client = table.Column<string>(type: "TEXT", nullable: false),
                    Handle = table.Column<string>(type: "TEXT", nullable: false),
                    DeliveryMethod = table.Column<string>(type: "TEXT", nullable: false),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Type = table.Column<string>(type: "TEXT", nullable: false),
                    HandleMan = table.Column<string>(type: "TEXT", nullable: false),
                    Explain = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OutMerchandiseList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BuyMerchandise",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Unit = table.Column<string>(type: "TEXT", nullable: false),
                    OrderNum = table.Column<int>(type: "INTEGER", nullable: false),
                    InboundNum = table.Column<int>(type: "INTEGER", nullable: false),
                    Remainder = table.Column<int>(type: "INTEGER", nullable: false),
                    BuyMerchandiseListId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuyMerchandise", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BuyMerchandise_BuyMerchandiseList_BuyMerchandiseListId",
                        column: x => x.BuyMerchandiseListId,
                        principalTable: "BuyMerchandiseList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OutMerchandise",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Unit = table.Column<string>(type: "TEXT", nullable: false),
                    OrderNum = table.Column<int>(type: "INTEGER", nullable: false),
                    PickingNum = table.Column<int>(type: "INTEGER", nullable: false),
                    SN = table.Column<string>(type: "TEXT", nullable: false),
                    BarCode = table.Column<string>(type: "TEXT", nullable: false),
                    OutMerchandiseListId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OutMerchandise", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OutMerchandise_OutMerchandiseList_OutMerchandiseListId",
                        column: x => x.OutMerchandiseListId,
                        principalTable: "OutMerchandiseList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BuyMerchandise_BuyMerchandiseListId",
                table: "BuyMerchandise",
                column: "BuyMerchandiseListId");

            migrationBuilder.CreateIndex(
                name: "IX_OutMerchandise_OutMerchandiseListId",
                table: "OutMerchandise",
                column: "OutMerchandiseListId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BuyMerchandise");

            migrationBuilder.DropTable(
                name: "Merchandise");

            migrationBuilder.DropTable(
                name: "OutMerchandise");

            migrationBuilder.DropTable(
                name: "BuyMerchandiseList");

            migrationBuilder.DropTable(
                name: "OutMerchandiseList");
        }
    }
}
