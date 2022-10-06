using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentGuidence.DataAccess.Migrations
{
    public partial class AddNewColumnToDepartmentModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PreRequirment",
                table: "Departments",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PreRequirment",
                table: "Departments");
        }
    }
}
