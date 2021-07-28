using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineFoodOrderingSystemAPIUsingEf.Migrations
{
    public partial class eighteen : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItem_Menu_MenuId",
                table: "OrderItem");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItem_Orders_ordersOrderId",
                table: "OrderItem");

            migrationBuilder.DropIndex(
                name: "IX_OrderItem_MenuId",
                table: "OrderItem");

            migrationBuilder.DropIndex(
                name: "IX_OrderItem_ordersOrderId",
                table: "OrderItem");

            migrationBuilder.DropColumn(
                name: "ordersOrderId",
                table: "OrderItem");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ordersOrderId",
                table: "OrderItem",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_MenuId",
                table: "OrderItem",
                column: "MenuId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_ordersOrderId",
                table: "OrderItem",
                column: "ordersOrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItem_Menu_MenuId",
                table: "OrderItem",
                column: "MenuId",
                principalTable: "Menu",
                principalColumn: "MenuId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItem_Orders_ordersOrderId",
                table: "OrderItem",
                column: "ordersOrderId",
                principalTable: "Orders",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
