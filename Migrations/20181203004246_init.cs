using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StudCabinetREST.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ApplicationMainInfo",
                columns: table => new
                {
                    ApplicationMainInfoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PassportId = table.Column<int>(nullable: false),
                    Citizenship = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Surename = table.Column<string>(nullable: true),
                    MiddleName = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<string>(nullable: true),
                    Gender = table.Column<bool>(nullable: false),
                    Birthplace = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    PhoneHome = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    AddressPasport = table.Column<string>(nullable: true),
                    AddressFact = table.Column<string>(nullable: true),
                    NeedOfHostel = table.Column<bool>(nullable: false),
                    Language = table.Column<string>(nullable: true),
                    DateOfApplication = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationMainInfo", x => x.ApplicationMainInfoId);
                });

            migrationBuilder.CreateTable(
                name: "CertificateType",
                columns: table => new
                {
                    CertificateTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CertificateType", x => x.CertificateTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Direction",
                columns: table => new
                {
                    DirectionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Direction", x => x.DirectionId);
                });

            migrationBuilder.CreateTable(
                name: "Faculty",
                columns: table => new
                {
                    FacultyId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faculty", x => x.FacultyId);
                });

            migrationBuilder.CreateTable(
                name: "InstitutionType",
                columns: table => new
                {
                    InstitutionTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstitutionType", x => x.InstitutionTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Object",
                columns: table => new
                {
                    ObjectId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Object", x => x.ObjectId);
                });

            migrationBuilder.CreateTable(
                name: "Specialization",
                columns: table => new
                {
                    SpecializationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specialization", x => x.SpecializationId);
                });

            migrationBuilder.CreateTable(
                name: "Military",
                columns: table => new
                {
                    MilitaryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    City = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    ApplicationMainInfoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Military", x => x.MilitaryId);
                    table.ForeignKey(
                        name: "FK_Military_ApplicationMainInfo_ApplicationMainInfoId",
                        column: x => x.ApplicationMainInfoId,
                        principalTable: "ApplicationMainInfo",
                        principalColumn: "ApplicationMainInfoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Passport",
                columns: table => new
                {
                    PassportId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Series = table.Column<string>(nullable: true),
                    Number = table.Column<string>(nullable: true),
                    Department = table.Column<string>(nullable: true),
                    DateOfIssue = table.Column<DateTime>(nullable: true),
                    ApplicationMainInfoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Passport", x => x.PassportId);
                    table.ForeignKey(
                        name: "FK_Passport_ApplicationMainInfo_ApplicationMainInfoId",
                        column: x => x.ApplicationMainInfoId,
                        principalTable: "ApplicationMainInfo",
                        principalColumn: "ApplicationMainInfoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Privileges",
                columns: table => new
                {
                    PrivilegeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ApplicationMainInfoId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Privileges", x => x.PrivilegeId);
                    table.ForeignKey(
                        name: "FK_Privileges_ApplicationMainInfo_ApplicationMainInfoId",
                        column: x => x.ApplicationMainInfoId,
                        principalTable: "ApplicationMainInfo",
                        principalColumn: "ApplicationMainInfoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reward",
                columns: table => new
                {
                    RewardId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ApplicationMainInfoId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reward", x => x.RewardId);
                    table.ForeignKey(
                        name: "FK_Reward_ApplicationMainInfo_ApplicationMainInfoId",
                        column: x => x.ApplicationMainInfoId,
                        principalTable: "ApplicationMainInfo",
                        principalColumn: "ApplicationMainInfoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Education",
                columns: table => new
                {
                    EducationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ApplicationMainInfoId = table.Column<int>(nullable: false),
                    InstitutionTypeId = table.Column<int>(nullable: false),
                    CertificateTypeId = table.Column<int>(nullable: false),
                    InstitutionName = table.Column<string>(nullable: true),
                    Point = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Education", x => x.EducationId);
                    table.ForeignKey(
                        name: "FK_Education_ApplicationMainInfo_ApplicationMainInfoId",
                        column: x => x.ApplicationMainInfoId,
                        principalTable: "ApplicationMainInfo",
                        principalColumn: "ApplicationMainInfoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Education_CertificateType_CertificateTypeId",
                        column: x => x.CertificateTypeId,
                        principalTable: "CertificateType",
                        principalColumn: "CertificateTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Education_InstitutionType_InstitutionTypeId",
                        column: x => x.InstitutionTypeId,
                        principalTable: "InstitutionType",
                        principalColumn: "InstitutionTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Exam",
                columns: table => new
                {
                    ExamId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ApplicationMainInfoId = table.Column<int>(nullable: false),
                    ObjectId = table.Column<int>(nullable: false),
                    Point = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exam", x => x.ExamId);
                    table.ForeignKey(
                        name: "FK_Exam_ApplicationMainInfo_ApplicationMainInfoId",
                        column: x => x.ApplicationMainInfoId,
                        principalTable: "ApplicationMainInfo",
                        principalColumn: "ApplicationMainInfoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Exam_Object_ObjectId",
                        column: x => x.ObjectId,
                        principalTable: "Object",
                        principalColumn: "ObjectId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Application",
                columns: table => new
                {
                    ApplicationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ApplicationMainInfoId = table.Column<int>(nullable: false),
                    FacultyId = table.Column<int>(nullable: false),
                    DirectionId = table.Column<int>(nullable: false),
                    SpecializationId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Application", x => x.ApplicationId);
                    table.ForeignKey(
                        name: "FK_Application_ApplicationMainInfo_ApplicationMainInfoId",
                        column: x => x.ApplicationMainInfoId,
                        principalTable: "ApplicationMainInfo",
                        principalColumn: "ApplicationMainInfoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Application_Direction_DirectionId",
                        column: x => x.DirectionId,
                        principalTable: "Direction",
                        principalColumn: "DirectionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Application_Faculty_FacultyId",
                        column: x => x.FacultyId,
                        principalTable: "Faculty",
                        principalColumn: "FacultyId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Application_Specialization_SpecializationId",
                        column: x => x.SpecializationId,
                        principalTable: "Specialization",
                        principalColumn: "SpecializationId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Application_ApplicationMainInfoId",
                table: "Application",
                column: "ApplicationMainInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_Application_DirectionId",
                table: "Application",
                column: "DirectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Application_FacultyId",
                table: "Application",
                column: "FacultyId");

            migrationBuilder.CreateIndex(
                name: "IX_Application_SpecializationId",
                table: "Application",
                column: "SpecializationId");

            migrationBuilder.CreateIndex(
                name: "IX_Education_ApplicationMainInfoId",
                table: "Education",
                column: "ApplicationMainInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_Education_CertificateTypeId",
                table: "Education",
                column: "CertificateTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Education_InstitutionTypeId",
                table: "Education",
                column: "InstitutionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Exam_ApplicationMainInfoId",
                table: "Exam",
                column: "ApplicationMainInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_Exam_ObjectId",
                table: "Exam",
                column: "ObjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Military_ApplicationMainInfoId",
                table: "Military",
                column: "ApplicationMainInfoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Passport_ApplicationMainInfoId",
                table: "Passport",
                column: "ApplicationMainInfoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Privileges_ApplicationMainInfoId",
                table: "Privileges",
                column: "ApplicationMainInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_Reward_ApplicationMainInfoId",
                table: "Reward",
                column: "ApplicationMainInfoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Application");

            migrationBuilder.DropTable(
                name: "Education");

            migrationBuilder.DropTable(
                name: "Exam");

            migrationBuilder.DropTable(
                name: "Military");

            migrationBuilder.DropTable(
                name: "Passport");

            migrationBuilder.DropTable(
                name: "Privileges");

            migrationBuilder.DropTable(
                name: "Reward");

            migrationBuilder.DropTable(
                name: "Direction");

            migrationBuilder.DropTable(
                name: "Faculty");

            migrationBuilder.DropTable(
                name: "Specialization");

            migrationBuilder.DropTable(
                name: "CertificateType");

            migrationBuilder.DropTable(
                name: "InstitutionType");

            migrationBuilder.DropTable(
                name: "Object");

            migrationBuilder.DropTable(
                name: "ApplicationMainInfo");
        }
    }
}
