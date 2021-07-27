using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineFoodOrderingSystemAPIUsingEf.Migrations
{
    public partial class nine : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payment_Order_Orderid",
                table: "Payment");

            migrationBuilder.DropIndex(
                name: "IX_Payment_Orderid",
                table: "Payment");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Payment_Orderid",
                table: "Payment",
                column: "Orderid");

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_Order_Orderid",
                table: "Payment",
                column: "Orderid",
                principalTable: "Order",
                principalColumn: "Orderid",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
