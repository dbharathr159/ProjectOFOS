using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineFoodOrderingSystemAPIUsingEf.Migrations
{
    public partial class firstone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admin",
                columns: table => new
                {
                    Userid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Password = table.Column<string>(type: "Varchar(20)", maxLength: 20, nullable: true),
                    FirstName = table.Column<string>(type: "Varchar(20)", maxLength: 20, nullable: true),
                    LastName = table.Column<string>(type: "Varchar(20)", maxLength: 20, nullable: true),
                    Email = table.Column<string>(type: "Varchar(20)", maxLength: 20, nullable: true),
                    Mobile = table.Column<long>(type: "Bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admin", x => x.Userid);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Customerid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "Varchar(20)", maxLength: 20, nullable: true),
                    LastName = table.Column<string>(type: "Varchar(20)", maxLength: 20, nullable: true),
                    Email = table.Column<string>(type: "Varchar(20)", maxLength: 20, nullable: true),
                    Mobile = table.Column<long>(type: "Bigint", nullable: true),
                    Password = table.Column<string>(type: "Varchar(20)", maxLength: 20, nullable: true),
                    Status = table.Column<string>(type: "Varchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Customerid);
                });

            migrationBuilder.CreateTable(
                name: "Menu",
                columns: table => new
                {
                    Menuid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuName = table.Column<string>(type: "Varchar(20)", maxLength: 20, nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: true),
                    Price = table.Column<decimal>(type: "Decimal", nullable: true),
                    FoodCategory = table.Column<string>(type: "Varchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menu", x => x.Menuid);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Orderid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderDate = table.Column<DateTime>(type: "Date", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "Decimal", nullable: true),
                    OrderStatus = table.Column<string>(type: "Varchar(20)", maxLength: 20, nullable: true),
                    Customerid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Orderid);
                    table.ForeignKey(
                        name: "FK_Order_Customer_Customerid",
                        column: x => x.Customerid,
                        principalTable: "Customer",
                        principalColumn: "Customerid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderItem",
                columns: table => new
                {
                    NoOfServing = table.Column<int>(type: "int", nullable: true),
                    Total = table.Column<decimal>(type: "Decimal", nullable: true),
                    Amount = table.Column<decimal>(type: "Decimal", nullable: true),
                    Orderid = table.Column<int>(type: "int", nullable: true),
                    Menuid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_OrderItem_Menu_Menuid",
                        column: x => x.Menuid,
                        principalTable: "Menu",
                        principalColumn: "Menuid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderItem_Order_Orderid",
                        column: x => x.Orderid,
                        principalTable: "Order",
                        principalColumn: "Orderid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Payment",
                columns: table => new
                {
                    Paymentid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TotalAmount = table.Column<decimal>(type: "Decimal", nullable: true),
                    PaidBy = table.Column<string>(type: "Varchar(20)", maxLength: 20, nullable: true),
                    Status = table.Column<string>(type: "Varchar(20)", maxLength: 20, nullable: true),
                    Orderid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.Paymentid);
                    table.ForeignKey(
                        name: "FK_Payment_Order_Orderid",
                        column: x => x.Orderid,
                        principalTable: "Order",
                        principalColumn: "Orderid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Order_Customerid",
                table: "Order",
                column: "Customerid");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_Menuid",
                table: "OrderItem",
                column: "Menuid");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_Orderid",
                table: "OrderItem",
                column: "Orderid");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_Orderid",
                table: "Payment",
                column: "Orderid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admin");

            migrationBuilder.DropTable(
                name: "OrderItem");

            migrationBuilder.DropTable(
                name: "Payment");

            migrationBuilder.DropTable(
                name: "Menu");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Customer");
        }
    }
}
