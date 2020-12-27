using Microsoft.EntityFrameworkCore.Migrations;

namespace BoletoCinema.Migrations
{
    public partial class add_role_UserController : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "rule",
                table: "users",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "rule",
                table: "users");
        }
    }
}
