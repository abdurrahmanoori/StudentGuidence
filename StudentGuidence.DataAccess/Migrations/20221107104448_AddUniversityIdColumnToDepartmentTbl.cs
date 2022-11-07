using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentGuidence.DataAccess.Migrations
{
    public partial class AddUniversityIdColumnToDepartmentTbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UniversityId",
                table: "Departments",
                nullable: true,
                defaultValue:null
                );

            migrationBuilder.CreateIndex(
                name: "IX_Departments_UniversityId",
                table: "Departments",
                column: "UniversityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Universities_UniversityId",
                table: "Departments",
                column: "UniversityId",
                principalTable: "Universities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Universities_UniversityId",
                table: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Departments_UniversityId",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "UniversityId",
                table: "Departments");
        }
    }
}
