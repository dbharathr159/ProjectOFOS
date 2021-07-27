using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineFoodOrderingSystemAPIUsingEf.Migrations
{
    public partial class tenth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItem_Menu_Menuid",
                table: "OrderItem");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItem_Order_Orderid",
                table: "OrderItem");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropIndex(
                name: "IX_OrderItem_Menuid",
                table: "OrderItem");

            migrationBuilder.DropIndex(
                name: "IX_OrderItem_Orderid",
                table: "OrderItem");

            migrationBuilder.RenameColumn(
                name: "Orderid",
                table: "Payment",
                newName: "OrderId");

            migrationBuilder.RenameColumn(
                name: "Paymentid",
                table: "Payment",
                newName: "PaymentId");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Payment",
                newName: "PaymentStatus");

            migrationBuilder.RenameColumn(
                name: "Orderid",
                table: "OrderItem",
                newName: "OrderId");

            migrationBuilder.RenameColumn(
                name: "Menuid",
                table: "OrderItem",
                newName: "MenuId");

            migrationBuilder.RenameColumn(
                name: "OrderItemid",
                table: "OrderItem",
                newName: "OrderItemId");

            migrationBuilder.RenameColumn(
                name: "Menuid",
                table: "Menu",
                newName: "MenuId");

            migrationBuilder.RenameColumn(
                name: "Customerid",
                table: "Customer",
                newName: "CustomerId");

            migrationBuilder.RenameColumn(
                name: "Userid",
                table: "Admin",
                newName: "UserId");

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderDate = table.Column<DateTime>(type: "Date", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "Decimal", nullable: true),
                    OrderStatus = table.Column<string>(type: "Varchar(20)", maxLength: 20, nullable: true),
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.RenameColumn(
                name: "OrderId",
                table: "Payment",
                newName: "Orderid");

            migrationBuilder.RenameColumn(
                name: "PaymentId",
                table: "Payment",
                newName: "Paymentid");

            migrationBuilder.RenameColumn(
                name: "PaymentStatus",
                table: "Payment",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "OrderId",
                table: "OrderItem",
                newName: "Orderid");

            migrationBuilder.RenameColumn(
                name: "MenuId",
                table: "OrderItem",
                newName: "Menuid");

            migrationBuilder.RenameColumn(
                name: "OrderItemId",
                table: "OrderItem",
                newName: "OrderItemid");

            migrationBuilder.RenameColumn(
                name: "MenuId",
                table: "Menu",
                newName: "Menuid");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "Customer",
                newName: "Customerid");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Admin",
                newName: "Userid");

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Orderid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Customerid = table.Column<int>(type: "int", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "Date", nullable: false),
                    OrderStatus = table.Column<string>(type: "Varchar(20)", maxLength: 20, nullable: true),
                    TotalAmount = table.Column<decimal>(type: "Decimal", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Orderid);
                    table.ForeignKey(
                        name: "FK_Order_Customer_Customerid",
                        column: x => x.Customerid,
                        principalTable: "Customer",
                        principalColumn: "Customerid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_Menuid",
                table: "OrderItem",
                column: "Menuid");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_Orderid",
                table: "OrderItem",
                column: "Orderid");

            migrationBuilder.CreateIndex(
                name: "IX_Order_Customerid",
                table: "Order",
                column: "Customerid");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItem_Menu_Menuid",
                table: "OrderItem",
                column: "Menuid",
                principalTable: "Menu",
                principalColumn: "Menuid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItem_Order_Orderid",
                table: "OrderItem",
                column: "Orderid",
                principalTable: "Order",
                principalColumn: "Orderid",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
