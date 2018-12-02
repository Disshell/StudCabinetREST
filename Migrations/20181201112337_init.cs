using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StudCabinetREST.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbstud");

            migrationBuilder.CreateTable(
                name: "certificate_type",
                schema: "dbstud",
                columns: table => new
                {
                    id_certificate_type = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(unicode: true, maxLength: 45, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_certificate_type", x => x.id_certificate_type);
                });

            migrationBuilder.CreateTable(
                name: "direction",
                schema: "dbstud",
                columns: table => new
                {
                    id_direction = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(unicode: true, maxLength: 45, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_direction", x => x.id_direction);
                });

            migrationBuilder.CreateTable(
                name: "faculty",
                schema: "dbstud",
                columns: table => new
                {
                    id_faculty = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(unicode: true, maxLength: 45, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_faculty", x => x.id_faculty);
                });

            migrationBuilder.CreateTable(
                name: "institution_type",
                schema: "dbstud",
                columns: table => new
                {
                    id_nstitution_type = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(unicode: true, maxLength: 45, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_institution_type", x => x.id_nstitution_type);
                });

            migrationBuilder.CreateTable(
                name: "object",
                schema: "dbstud",
                columns: table => new
                {
                    object_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(unicode: true, maxLength: 45, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_object", x => x.object_id);
                });

            migrationBuilder.CreateTable(
                name: "passport",
                schema: "dbstud",
                columns: table => new
                {
                    id_passport = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    series = table.Column<string>(unicode: true, maxLength: 45, nullable: true),
                    number = table.Column<string>(unicode: true, maxLength: 45, nullable: true),
                    department = table.Column<string>(unicode: true, maxLength: 45, nullable: true),
                    date_of_issue = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_passport", x => x.id_passport);
                });

            migrationBuilder.CreateTable(
                name: "specialization",
                schema: "dbstud",
                columns: table => new
                {
                    id_specialization = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(unicode: true, maxLength: 45, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_specialization", x => x.id_specialization);
                });

            migrationBuilder.CreateTable(
                name: "status",
                schema: "dbstud",
                columns: table => new
                {
                    id_status = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(unicode: true, maxLength: 45, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_status", x => x.id_status);
                });

            migrationBuilder.CreateTable(
                name: "application_main_info",
                schema: "dbstud",
                columns: table => new
                {
                    id_student_info = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    id_passport = table.Column<int>(type: "int", nullable: false),
                    status_id_status = table.Column<int>(type: "int", nullable: false),
                    citizenship = table.Column<string>(unicode: true, maxLength: 45, nullable: true),
                    name = table.Column<string>(unicode: true, maxLength: 45, nullable: true),
                    surename = table.Column<string>(unicode: true, maxLength: 45, nullable: true),
                    student_infocol = table.Column<string>(unicode: true, maxLength: 45, nullable: true),
                    middle_name = table.Column<string>(unicode: true, maxLength: 45, nullable: true),
                    date_of_birth = table.Column<string>(unicode: true, maxLength: 45, nullable: true),
                    student_infocol1 = table.Column<string>(unicode: true, maxLength: 45, nullable: true),
                    gender = table.Column<byte>(type: "tinyint", nullable: true),
                    birthplace = table.Column<string>(unicode: true, maxLength: 45, nullable: true),
                    phone = table.Column<string>(unicode: true, maxLength: 45, nullable: true),
                    phone_home = table.Column<string>(unicode: true, maxLength: 45, nullable: true),
                    email = table.Column<string>(unicode: true, maxLength: 45, nullable: true),
                    address_pasport = table.Column<string>(unicode: true, maxLength: 400, nullable: true),
                    address_fact = table.Column<string>(unicode: true, maxLength: 400, nullable: true),
                    need_of_hostel = table.Column<byte>(type: "tinyint", nullable: true),
                    language = table.Column<string>(unicode: true, maxLength: 45, nullable: true),
                    date_of_application = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_application_main_info", x => x.id_student_info);
                    table.ForeignKey(
                        name: "fk_student_info_passport",
                        column: x => x.id_passport,
                        principalSchema: "dbstud",
                        principalTable: "passport",
                        principalColumn: "id_passport",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_application_main_info_status1",
                        column: x => x.status_id_status,
                        principalSchema: "dbstud",
                        principalTable: "status",
                        principalColumn: "id_status",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "application",
                schema: "dbstud",
                columns: table => new
                {
                    id_application = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    id_student_info = table.Column<int>(type: "int", nullable: false),
                    id_faculty = table.Column<int>(type: "int", nullable: false),
                    id_direction = table.Column<int>(type: "int", nullable: false),
                    id_specialization = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_application", x => x.id_application);
                    table.ForeignKey(
                        name: "fk_application_direction1",
                        column: x => x.id_direction,
                        principalSchema: "dbstud",
                        principalTable: "direction",
                        principalColumn: "id_direction",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_application_faculty1",
                        column: x => x.id_faculty,
                        principalSchema: "dbstud",
                        principalTable: "faculty",
                        principalColumn: "id_faculty",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_application_specialization1",
                        column: x => x.id_specialization,
                        principalSchema: "dbstud",
                        principalTable: "specialization",
                        principalColumn: "id_specialization",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_application_student_info1",
                        column: x => x.id_student_info,
                        principalSchema: "dbstud",
                        principalTable: "application_main_info",
                        principalColumn: "id_student_info",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "education",
                schema: "dbstud",
                columns: table => new
                {
                    id_education = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    id_student_info = table.Column<int>(type: "int", nullable: false),
                    id_institution_type = table.Column<int>(type: "int", nullable: false),
                    id_certificate_type = table.Column<int>(type: "int", nullable: false),
                    institution_name = table.Column<string>(unicode: true, maxLength: 45, nullable: true),
                    point = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_education", x => x.id_education);
                    table.ForeignKey(
                        name: "fk_education_certificate_type1",
                        column: x => x.id_certificate_type,
                        principalSchema: "dbstud",
                        principalTable: "certificate_type",
                        principalColumn: "id_certificate_type",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_education_institution_type1",
                        column: x => x.id_institution_type,
                        principalSchema: "dbstud",
                        principalTable: "institution_type",
                        principalColumn: "id_nstitution_type",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_education_student_info1",
                        column: x => x.id_student_info,
                        principalSchema: "dbstud",
                        principalTable: "application_main_info",
                        principalColumn: "id_student_info",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "exam",
                schema: "dbstud",
                columns: table => new
                {
                    id_exams = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    id_student_info = table.Column<int>(type: "int", nullable: false),
                    object_id = table.Column<int>(type: "int", nullable: false),
                    examcol = table.Column<string>(unicode: true, maxLength: 45, nullable: true),
                    point = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_exam", x => x.id_exams);
                    table.ForeignKey(
                        name: "fk_exam_student_info1",
                        column: x => x.id_student_info,
                        principalSchema: "dbstud",
                        principalTable: "application_main_info",
                        principalColumn: "id_student_info",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_exam_object1",
                        column: x => x.object_id,
                        principalSchema: "dbstud",
                        principalTable: "object",
                        principalColumn: "object_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "privilege",
                schema: "dbstud",
                columns: table => new
                {
                    id_privilege = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    id_student_info = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(unicode: true, maxLength: 45, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_privilege", x => x.id_privilege);
                    table.ForeignKey(
                        name: "fk_privilege_student_info1",
                        column: x => x.id_student_info,
                        principalSchema: "dbstud",
                        principalTable: "application_main_info",
                        principalColumn: "id_student_info",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "reward",
                schema: "dbstud",
                columns: table => new
                {
                    id_award = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    id_student_info = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(unicode: true, maxLength: 45, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reward", x => x.id_award);
                    table.ForeignKey(
                        name: "fk_reward_student_info1",
                        column: x => x.id_student_info,
                        principalSchema: "dbstud",
                        principalTable: "application_main_info",
                        principalColumn: "id_student_info",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "fk_application_direction1_idx",
                schema: "dbstud",
                table: "application",
                column: "id_direction");

            migrationBuilder.CreateIndex(
                name: "fk_application_faculty1_idx",
                schema: "dbstud",
                table: "application",
                column: "id_faculty");

            migrationBuilder.CreateIndex(
                name: "fk_application_specialization1_idx",
                schema: "dbstud",
                table: "application",
                column: "id_specialization");

            migrationBuilder.CreateIndex(
                name: "fk_application_student_info1_idx",
                schema: "dbstud",
                table: "application",
                column: "id_student_info");

            migrationBuilder.CreateIndex(
                name: "fk_student_info_passport_idx",
                schema: "dbstud",
                table: "application_main_info",
                column: "id_passport");

            migrationBuilder.CreateIndex(
                name: "fk_application_main_info_status1_idx",
                schema: "dbstud",
                table: "application_main_info",
                column: "status_id_status");

            migrationBuilder.CreateIndex(
                name: "fk_education_certificate_type1_idx",
                schema: "dbstud",
                table: "education",
                column: "id_certificate_type");

            migrationBuilder.CreateIndex(
                name: "fk_education_institution_type1_idx",
                schema: "dbstud",
                table: "education",
                column: "id_institution_type");

            migrationBuilder.CreateIndex(
                name: "fk_education_student_info1_idx",
                schema: "dbstud",
                table: "education",
                column: "id_student_info");

            migrationBuilder.CreateIndex(
                name: "fk_exam_student_info1_idx",
                schema: "dbstud",
                table: "exam",
                column: "id_student_info");

            migrationBuilder.CreateIndex(
                name: "fk_exam_object1_idx",
                schema: "dbstud",
                table: "exam",
                column: "object_id");

            migrationBuilder.CreateIndex(
                name: "fk_privilege_student_info1_idx",
                schema: "dbstud",
                table: "privilege",
                column: "id_student_info");

            migrationBuilder.CreateIndex(
                name: "fk_reward_student_info1_idx",
                schema: "dbstud",
                table: "reward",
                column: "id_student_info");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "application",
                schema: "dbstud");

            migrationBuilder.DropTable(
                name: "education",
                schema: "dbstud");

            migrationBuilder.DropTable(
                name: "exam",
                schema: "dbstud");

            migrationBuilder.DropTable(
                name: "privilege",
                schema: "dbstud");

            migrationBuilder.DropTable(
                name: "reward",
                schema: "dbstud");

            migrationBuilder.DropTable(
                name: "direction",
                schema: "dbstud");

            migrationBuilder.DropTable(
                name: "faculty",
                schema: "dbstud");

            migrationBuilder.DropTable(
                name: "specialization",
                schema: "dbstud");

            migrationBuilder.DropTable(
                name: "certificate_type",
                schema: "dbstud");

            migrationBuilder.DropTable(
                name: "institution_type",
                schema: "dbstud");

            migrationBuilder.DropTable(
                name: "object",
                schema: "dbstud");

            migrationBuilder.DropTable(
                name: "application_main_info",
                schema: "dbstud");

            migrationBuilder.DropTable(
                name: "passport",
                schema: "dbstud");

            migrationBuilder.DropTable(
                name: "status",
                schema: "dbstud");
        }
    }
}
