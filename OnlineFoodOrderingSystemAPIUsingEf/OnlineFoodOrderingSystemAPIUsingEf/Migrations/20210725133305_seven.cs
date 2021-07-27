using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineFoodOrderingSystemAPIUsingEf.Migrations
{
    public partial class seven : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Customer_Customerid",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItem_Menu_Menuid",
                table: "OrderItem");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItem_Order_Orderid",
                table: "OrderItem");

            migrationBuilder.DropForeignKey(
                name: "FK_Payment_Order_Orderid",
                table: "Payment");

            migrationBuilder.AlterColumn<int>(
                name: "Orderid",
                table: "Payment",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Orderid",
                table: "OrderItem",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Menuid",
                table: "OrderItem",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Customerid",
                table: "Order",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Menu",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "Decimal",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "Mobile",
                table: "Admin",
                type: "Bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "Bigint",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Customer_Customerid",
                table: "Order",
                column: "Customerid",
                principalTable: "Customer",
                principalColumn: "Customerid",
                onDelete: ReferentialAction.Cascade);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_Order_Orderid",
                table: "Payment",
                column: "Orderid",
                principalTable: "Order",
                principalColumn: "Orderid",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Customer_Customerid",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItem_Menu_Menuid",
                table: "OrderItem");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItem_Order_Orderid",
                table: "OrderItem");

            migrationBuilder.DropForeignKey(
                name: "FK_Payment_Order_Orderid",
                table: "Payment");

            migrationBuilder.AlterColumn<int>(
                name: "Orderid",
                table: "Payment",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Orderid",
                table: "OrderItem",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Menuid",
                table: "OrderItem",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Customerid",
                table: "Order",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Menu",
                type: "Decimal",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<long>(
                name: "Mobile",
                table: "Admin",
                type: "Bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "Bigint");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Customer_Customerid",
                table: "Order",
                column: "Customerid",
                principalTable: "Customer",
                principalColumn: "Customerid",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItem_Menu_Menuid",
                table: "OrderItem",
                column: "Menuid",
                principalTable: "Menu",
                principalColumn: "Menuid",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItem_Order_Orderid",
                table: "OrderItem",
                column: "Orderid",
                principalTable: "Order",
                principalColumn: "Orderid",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_Order_Orderid",
                table: "Payment",
                column: "Orderid",
                principalTable: "Order",
                principalColumn: "Orderid",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
