using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentGuidence.DataAccess.Migrations
{
    public partial class RemovedUniversityEstablishDefaultValueToEmpty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Establishment",
                table: "Universities",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 13, 10, 53, 16, 326, DateTimeKind.Local).AddTicks(2091),
                oldClrType: typeof(DateTime),
                oldType: "Date");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Establishment",
                table: "Universities",
                type: "Date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldDefaultValue: new DateTime(2022, 10, 13, 10, 53, 16, 326, DateTimeKind.Local).AddTicks(2091));
        }
    }
}
