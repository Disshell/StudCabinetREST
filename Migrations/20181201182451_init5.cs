using Microsoft.EntityFrameworkCore.Migrations;

namespace StudCabinetREST.Migrations
{
    public partial class init5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StudentInfocol",
                schema: "dbstud",
                table: "application_main_info");

            migrationBuilder.AlterColumn<byte>(
                name: "need_of_hostel",
                schema: "dbstud",
                table: "application_main_info",
                type: "tinyint",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true);

            migrationBuilder.AlterColumn<byte>(
                name: "gender",
                schema: "dbstud",
                table: "application_main_info",
                type: "tinyint",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte>(
                name: "need_of_hostel",
                schema: "dbstud",
                table: "application_main_info",
                type: "tinyint",
                nullable: true,
                oldClrType: typeof(byte),
                oldType: "tinyint");

            migrationBuilder.AlterColumn<byte>(
                name: "gender",
                schema: "dbstud",
                table: "application_main_info",
                type: "tinyint",
                nullable: true,
                oldClrType: typeof(byte),
                oldType: "tinyint");

            migrationBuilder.AddColumn<string>(
                name: "StudentInfocol",
                schema: "dbstud",
                table: "application_main_info",
                nullable: true);
        }
    }
}
