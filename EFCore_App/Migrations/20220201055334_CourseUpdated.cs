using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCore_App.Migrations
{
    public partial class CourseUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Student",
                newName: "StudentName");

            migrationBuilder.AddColumn<int>(
                name: "CourseEnrolled",
                table: "Student",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CourseEnrolled",
                table: "Student");

            migrationBuilder.RenameColumn(
                name: "StudentName",
                table: "Student",
                newName: "Name");
        }
    }
}
