using Microsoft.EntityFrameworkCore.Migrations;

namespace StudCabinetREST.Migrations
{
    public partial class init4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AuthId",
                table: "ApplicationMainInfo",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AuthId",
                table: "ApplicationMainInfo");
        }
    }
}
