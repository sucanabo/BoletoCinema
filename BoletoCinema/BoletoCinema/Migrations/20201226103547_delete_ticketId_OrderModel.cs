using Microsoft.EntityFrameworkCore.Migrations;

namespace BoletoCinema.Migrations
{
    public partial class delete_ticketId_OrderModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ticket_id",
                table: "orders");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ticket_id",
                table: "orders",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
