using Microsoft.EntityFrameworkCore.Migrations;

namespace StudCabinetREST.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_application_student_info1",
                schema: "dbstud",
                table: "application");

            migrationBuilder.DropForeignKey(
                name: "fk_student_info_passport",
                schema: "dbstud",
                table: "application_main_info");

            migrationBuilder.DropForeignKey(
                name: "fk_education_student_info1",
                schema: "dbstud",
                table: "education");

            migrationBuilder.DropForeignKey(
                name: "fk_exam_student_info1",
                schema: "dbstud",
                table: "exam");

            migrationBuilder.DropForeignKey(
                name: "fk_privilege_student_info1",
                schema: "dbstud",
                table: "privilege");

            migrationBuilder.DropForeignKey(
                name: "fk_reward_student_info1",
                schema: "dbstud",
                table: "reward");

            migrationBuilder.RenameColumn(
                name: "id_student_info",
                schema: "dbstud",
                table: "reward",
                newName: "id_application_main_info");

            migrationBuilder.RenameIndex(
                name: "fk_reward_student_info1_idx",
                schema: "dbstud",
                table: "reward",
                newName: "fk_reward_application_main_info1_idx");

            migrationBuilder.RenameColumn(
                name: "id_student_info",
                schema: "dbstud",
                table: "privilege",
                newName: "id_application_main");

            migrationBuilder.RenameIndex(
                name: "fk_privilege_student_info1_idx",
                schema: "dbstud",
                table: "privilege",
                newName: "fk_privilege_application_main_info1_idx");

            migrationBuilder.RenameColumn(
                name: "id_student_info",
                schema: "dbstud",
                table: "exam",
                newName: "id_application_main_info");

            migrationBuilder.RenameIndex(
                name: "fk_exam_student_info1_idx",
                schema: "dbstud",
                table: "exam",
                newName: "fk_exam_applicatin_main_info1_idx");

            migrationBuilder.RenameColumn(
                name: "id_student_info",
                schema: "dbstud",
                table: "education",
                newName: "id_application_main_info");

            migrationBuilder.RenameIndex(
                name: "fk_education_student_info1_idx",
                schema: "dbstud",
                table: "education",
                newName: "fk_education_application_main_info1_idx");

            migrationBuilder.RenameColumn(
                name: "student_infocol1",
                schema: "dbstud",
                table: "application_main_info",
                newName: "StudentInfocol1");

            migrationBuilder.RenameColumn(
                name: "student_infocol",
                schema: "dbstud",
                table: "application_main_info",
                newName: "StudentInfocol");

            migrationBuilder.RenameColumn(
                name: "id_student_info",
                schema: "dbstud",
                table: "application_main_info",
                newName: "id_application_main_info");

            migrationBuilder.RenameIndex(
                name: "fk_student_info_passport_idx",
                schema: "dbstud",
                table: "application_main_info",
                newName: "fk_application_main_info_passport_idx");

            migrationBuilder.RenameColumn(
                name: "id_student_info",
                schema: "dbstud",
                table: "application",
                newName: "id_application_main_info");

            migrationBuilder.RenameIndex(
                name: "fk_application_student_info1_idx",
                schema: "dbstud",
                table: "application",
                newName: "fk_application_application_main_info1_idx");

            migrationBuilder.AlterColumn<string>(
                name: "StudentInfocol1",
                schema: "dbstud",
                table: "application_main_info",
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 45,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "StudentInfocol",
                schema: "dbstud",
                table: "application_main_info",
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 45,
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "fk_application_application_main_info1",
                schema: "dbstud",
                table: "application",
                column: "id_application_main_info",
                principalSchema: "dbstud",
                principalTable: "application_main_info",
                principalColumn: "id_application_main_info",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_application_main_info_passport",
                schema: "dbstud",
                table: "application_main_info",
                column: "id_passport",
                principalSchema: "dbstud",
                principalTable: "passport",
                principalColumn: "id_passport",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_education_application_main_info1",
                schema: "dbstud",
                table: "education",
                column: "id_application_main_info",
                principalSchema: "dbstud",
                principalTable: "application_main_info",
                principalColumn: "id_application_main_info",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_exam_application_main_info1",
                schema: "dbstud",
                table: "exam",
                column: "id_application_main_info",
                principalSchema: "dbstud",
                principalTable: "application_main_info",
                principalColumn: "id_application_main_info",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_privilege_application_main_info1",
                schema: "dbstud",
                table: "privilege",
                column: "id_application_main",
                principalSchema: "dbstud",
                principalTable: "application_main_info",
                principalColumn: "id_application_main_info",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_reward_application_main_info1",
                schema: "dbstud",
                table: "reward",
                column: "id_application_main_info",
                principalSchema: "dbstud",
                principalTable: "application_main_info",
                principalColumn: "id_application_main_info",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_application_application_main_info1",
                schema: "dbstud",
                table: "application");

            migrationBuilder.DropForeignKey(
                name: "fk_application_main_info_passport",
                schema: "dbstud",
                table: "application_main_info");

            migrationBuilder.DropForeignKey(
                name: "fk_education_application_main_info1",
                schema: "dbstud",
                table: "education");

            migrationBuilder.DropForeignKey(
                name: "fk_exam_application_main_info1",
                schema: "dbstud",
                table: "exam");

            migrationBuilder.DropForeignKey(
                name: "fk_privilege_application_main_info1",
                schema: "dbstud",
                table: "privilege");

            migrationBuilder.DropForeignKey(
                name: "fk_reward_application_main_info1",
                schema: "dbstud",
                table: "reward");

            migrationBuilder.RenameColumn(
                name: "id_application_main_info",
                schema: "dbstud",
                table: "reward",
                newName: "id_student_info");

            migrationBuilder.RenameIndex(
                name: "fk_reward_application_main_info1_idx",
                schema: "dbstud",
                table: "reward",
                newName: "fk_reward_student_info1_idx");

            migrationBuilder.RenameColumn(
                name: "id_application_main",
                schema: "dbstud",
                table: "privilege",
                newName: "id_student_info");

            migrationBuilder.RenameIndex(
                name: "fk_privilege_application_main_info1_idx",
                schema: "dbstud",
                table: "privilege",
                newName: "fk_privilege_student_info1_idx");

            migrationBuilder.RenameColumn(
                name: "id_application_main_info",
                schema: "dbstud",
                table: "exam",
                newName: "id_student_info");

            migrationBuilder.RenameIndex(
                name: "fk_exam_applicatin_main_info1_idx",
                schema: "dbstud",
                table: "exam",
                newName: "fk_exam_student_info1_idx");

            migrationBuilder.RenameColumn(
                name: "id_application_main_info",
                schema: "dbstud",
                table: "education",
                newName: "id_student_info");

            migrationBuilder.RenameIndex(
                name: "fk_education_application_main_info1_idx",
                schema: "dbstud",
                table: "education",
                newName: "fk_education_student_info1_idx");

            migrationBuilder.RenameColumn(
                name: "StudentInfocol1",
                schema: "dbstud",
                table: "application_main_info",
                newName: "student_infocol1");

            migrationBuilder.RenameColumn(
                name: "StudentInfocol",
                schema: "dbstud",
                table: "application_main_info",
                newName: "student_infocol");

            migrationBuilder.RenameColumn(
                name: "id_application_main_info",
                schema: "dbstud",
                table: "application_main_info",
                newName: "id_student_info");

            migrationBuilder.RenameIndex(
                name: "fk_application_main_info_passport_idx",
                schema: "dbstud",
                table: "application_main_info",
                newName: "fk_student_info_passport_idx");

            migrationBuilder.RenameColumn(
                name: "id_application_main_info",
                schema: "dbstud",
                table: "application",
                newName: "id_student_info");

            migrationBuilder.RenameIndex(
                name: "fk_application_application_main_info1_idx",
                schema: "dbstud",
                table: "application",
                newName: "fk_application_student_info1_idx");

            migrationBuilder.AlterColumn<string>(
                name: "student_infocol1",
                schema: "dbstud",
                table: "application_main_info",
                unicode: false,
                maxLength: 45,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "student_infocol",
                schema: "dbstud",
                table: "application_main_info",
                unicode: false,
                maxLength: 45,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "fk_application_student_info1",
                schema: "dbstud",
                table: "application",
                column: "id_student_info",
                principalSchema: "dbstud",
                principalTable: "application_main_info",
                principalColumn: "id_student_info",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_student_info_passport",
                schema: "dbstud",
                table: "application_main_info",
                column: "id_passport",
                principalSchema: "dbstud",
                principalTable: "passport",
                principalColumn: "id_passport",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_education_student_info1",
                schema: "dbstud",
                table: "education",
                column: "id_student_info",
                principalSchema: "dbstud",
                principalTable: "application_main_info",
                principalColumn: "id_student_info",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_exam_student_info1",
                schema: "dbstud",
                table: "exam",
                column: "id_student_info",
                principalSchema: "dbstud",
                principalTable: "application_main_info",
                principalColumn: "id_student_info",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_privilege_student_info1",
                schema: "dbstud",
                table: "privilege",
                column: "id_student_info",
                principalSchema: "dbstud",
                principalTable: "application_main_info",
                principalColumn: "id_student_info",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_reward_student_info1",
                schema: "dbstud",
                table: "reward",
                column: "id_student_info",
                principalSchema: "dbstud",
                principalTable: "application_main_info",
                principalColumn: "id_student_info",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
