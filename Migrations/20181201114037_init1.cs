using Microsoft.EntityFrameworkCore.Migrations;

namespace StudCabinetREST.Migrations
{
    public partial class init1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "examcol",
                schema: "dbstud",
                table: "exam");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "examcol",
                schema: "dbstud",
                table: "exam",
                unicode: false,
                maxLength: 45,
                nullable: true);
        }
    }
}
