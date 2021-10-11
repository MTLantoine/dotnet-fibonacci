using Microsoft.EntityFrameworkCore.Migrations;

namespace Fibonacci.Migrations
{
    public partial class AddFibFibonacciCreatedTimestamp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FibCreatedTimestamp",
                schema: "sch_fib",
                table: "T_Fibonacci",
                newName: "FIB_CreatedTimestamp");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FIB_CreatedTimestamp",
                schema: "sch_fib",
                table: "T_Fibonacci",
                newName: "FibCreatedTimestamp");
        }
    }
}
