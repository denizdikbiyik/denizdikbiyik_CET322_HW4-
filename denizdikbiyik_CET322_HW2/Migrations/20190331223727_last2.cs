using Microsoft.EntityFrameworkCore.Migrations;

namespace denizdikbiyik_CET322_HW2.Migrations
{
    public partial class last2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Student",
                newName: "FileUrl");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FileUrl",
                table: "Student",
                newName: "ImageUrl");
        }
    }
}
