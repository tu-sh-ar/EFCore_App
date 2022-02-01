using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCore_App.Migrations
{
    public partial class RelationAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CourseEnrolled",
                table: "Student",
                newName: "CourseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CourseId",
                table: "Student",
                newName: "CourseEnrolled");
        }
    }
}
