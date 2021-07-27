using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineFoodOrderingSystemAPIUsingEf.Migrations
{
    public partial class thirteen : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "TotalAmount",
                table: "Payment",
                type: "Decimal",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "Decimal",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalAmount",
                table: "Orders",
                type: "Decimal",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "Decimal",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Total",
                table: "OrderItem",
                type: "Decimal",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "Decimal",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "NoOfServing",
                table: "OrderItem",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Amount",
                table: "OrderItem",
                type: "Decimal",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "Decimal",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Quantity",
                table: "Menu",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "TotalAmount",
                table: "Payment",
                type: "Decimal",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "Decimal");

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalAmount",
                table: "Orders",
                type: "Decimal",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "Decimal");

            migrationBuilder.AlterColumn<decimal>(
                name: "Total",
                table: "OrderItem",
                type: "Decimal",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "Decimal");

            migrationBuilder.AlterColumn<int>(
                name: "NoOfServing",
                table: "OrderItem",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<decimal>(
                name: "Amount",
                table: "OrderItem",
                type: "Decimal",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "Decimal");

            migrationBuilder.AlterColumn<int>(
                name: "Quantity",
                table: "Menu",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
