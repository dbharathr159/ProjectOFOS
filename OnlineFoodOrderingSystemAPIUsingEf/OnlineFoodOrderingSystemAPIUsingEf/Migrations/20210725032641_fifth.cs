using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineFoodOrderingSystemAPIUsingEf.Migrations
{
    public partial class fifth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "Mobile",
                table: "Customer",
                type: "Bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "Bigint",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "Mobile",
                table: "Customer",
                type: "Bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "Bigint");
        }
    }
}
