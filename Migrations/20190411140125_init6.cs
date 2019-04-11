using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StudCabinetREST.Migrations
{
    public partial class init6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "DateOfIssue",
                table: "Passport",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DateOfApplication",
                table: "ApplicationMainInfo",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfIssue",
                table: "Passport",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfApplication",
                table: "ApplicationMainInfo",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
