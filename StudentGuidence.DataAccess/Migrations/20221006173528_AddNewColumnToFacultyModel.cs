using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentGuidence.DataAccess.Migrations
{
    public partial class AddNewColumnToFacultyModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PreRequirment",
                table: "Faculties",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PreRequirment",
                table: "Faculties");
        }
    }
}
