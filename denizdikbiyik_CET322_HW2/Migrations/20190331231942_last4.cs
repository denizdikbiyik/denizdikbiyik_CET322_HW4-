using Microsoft.EntityFrameworkCore.Migrations;

namespace denizdikbiyik_CET322_HW2.Migrations
{
    public partial class last4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Content",
                table: "Student",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Content",
                table: "Student");
        }
    }
}
