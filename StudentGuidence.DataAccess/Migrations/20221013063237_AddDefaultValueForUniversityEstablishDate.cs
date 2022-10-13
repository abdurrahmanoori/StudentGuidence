using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentGuidence.DataAccess.Migrations
{
    public partial class AddDefaultValueForUniversityEstablishDate : Migration
    {

        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //DateTime d = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            migrationBuilder.AlterColumn<DateTime>(
                name: "Establishment",
                table: "Universities",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day),
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldDefaultValue: new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day).AddTicks(2091));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Establishment",
                table: "Universities",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day).AddTicks(2091),
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldDefaultValue: new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day));
        }
    }
}
