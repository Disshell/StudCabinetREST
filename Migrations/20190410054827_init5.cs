using Microsoft.EntityFrameworkCore.Migrations;

namespace StudCabinetREST.Migrations
{
    public partial class init5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PassportId",
                table: "ApplicationMainInfo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PassportId",
                table: "ApplicationMainInfo",
                nullable: false,
                defaultValue: 0);
        }
    }
}
