using Microsoft.EntityFrameworkCore.Migrations;

namespace SaleReporing.Data.Migrations
{
    public partial class initialv1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Employee",
                table: "SaleRaporing",
                newName: "Customer");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Customer",
                table: "SaleRaporing",
                newName: "Employee");
        }
    }
}
