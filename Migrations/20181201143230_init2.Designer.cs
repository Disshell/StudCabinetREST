﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudCabinetREST.Models;

namespace StudCabinetREST.Migrations
{
    [DbContext(typeof(StudDBContext))]
    [Migration("20181201143230_init2")]
    partial class init2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("StudCabinetREST.Models.Application", b =>
                {
                    b.Property<int>("IdApplication")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id_application")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdApplicationMainInfo")
                        .HasColumnName("id_application_main_info")
                        .HasColumnType("int");

                    b.Property<int>("IdDirection")
                        .HasColumnName("id_direction")
                        .HasColumnType("int");

                    b.Property<int>("IdFaculty")
                        .HasColumnName("id_faculty")
                        .HasColumnType("int");

                    b.Property<int>("IdSpecialization")
                        .HasColumnName("id_specialization")
                        .HasColumnType("int");

                    b.HasKey("IdApplication");

                    b.HasIndex("IdApplicationMainInfo")
                        .HasName("fk_application_application_main_info1_idx");

                    b.HasIndex("IdDirection")
                        .HasName("fk_application_direction1_idx");

                    b.HasIndex("IdFaculty")
                        .HasName("fk_application_faculty1_idx");

                    b.HasIndex("IdSpecialization")
                        .HasName("fk_application_specialization1_idx");

                    b.ToTable("application","dbstud");
                });

            modelBuilder.Entity("StudCabinetREST.Models.ApplicationMainInfo", b =>
                {
                    b.Property<int>("IdApplicationMainInfo")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id_application_main_info")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddressFact")
                        .HasColumnName("address_fact")
                        .HasMaxLength(400)
                        .IsUnicode(false);

                    b.Property<string>("AddressPasport")
                        .HasColumnName("address_pasport")
                        .HasMaxLength(400)
                        .IsUnicode(false);

                    b.Property<string>("Birthplace")
                        .HasColumnName("birthplace")
                        .HasMaxLength(45)
                        .IsUnicode(false);

                    b.Property<string>("Citizenship")
                        .HasColumnName("citizenship")
                        .HasMaxLength(45)
                        .IsUnicode(false);

                    b.Property<DateTime?>("DateOfApplication")
                        .HasColumnName("date_of_application")
                        .HasColumnType("date");

                    b.Property<string>("DateOfBirth")
                        .HasColumnName("date_of_birth")
                        .HasMaxLength(45)
                        .IsUnicode(false);

                    b.Property<string>("Email")
                        .HasColumnName("email")
                        .HasMaxLength(45)
                        .IsUnicode(false);

                    b.Property<byte?>("Gender")
                        .HasColumnName("gender")
                        .HasColumnType("tinyint");

                    b.Property<int>("IdPassport")
                        .HasColumnName("id_passport")
                        .HasColumnType("int");

                    b.Property<string>("Language")
                        .HasColumnName("language")
                        .HasMaxLength(45)
                        .IsUnicode(false);

                    b.Property<string>("MiddleName")
                        .HasColumnName("middle_name")
                        .HasMaxLength(45)
                        .IsUnicode(false);

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasMaxLength(45)
                        .IsUnicode(false);

                    b.Property<byte?>("NeedOfHostel")
                        .HasColumnName("need_of_hostel")
                        .HasColumnType("tinyint");

                    b.Property<string>("Phone")
                        .HasColumnName("phone")
                        .HasMaxLength(45)
                        .IsUnicode(false);

                    b.Property<string>("PhoneHome")
                        .HasColumnName("phone_home")
                        .HasMaxLength(45)
                        .IsUnicode(false);

                    b.Property<int>("StatusIdStatus")
                        .HasColumnName("status_id_status")
                        .HasColumnType("int");

                    b.Property<string>("StudentInfocol");

                    b.Property<string>("StudentInfocol1");

                    b.Property<string>("Surename")
                        .HasColumnName("surename")
                        .HasMaxLength(45)
                        .IsUnicode(false);

                    b.HasKey("IdApplicationMainInfo");

                    b.HasIndex("IdPassport")
                        .HasName("fk_application_main_info_passport_idx");

                    b.HasIndex("StatusIdStatus")
                        .HasName("fk_application_main_info_status1_idx");

                    b.ToTable("application_main_info","dbstud");
                });

            modelBuilder.Entity("StudCabinetREST.Models.CertificateType", b =>
                {
                    b.Property<int>("IdCertificateType")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id_certificate_type")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasMaxLength(45)
                        .IsUnicode(false);

                    b.HasKey("IdCertificateType");

                    b.ToTable("certificate_type","dbstud");
                });

            modelBuilder.Entity("StudCabinetREST.Models.Direction", b =>
                {
                    b.Property<int>("IdDirection")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id_direction")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasMaxLength(45)
                        .IsUnicode(false);

                    b.HasKey("IdDirection");

                    b.ToTable("direction","dbstud");
                });

            modelBuilder.Entity("StudCabinetREST.Models.Education", b =>
                {
                    b.Property<int>("IdEducation")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id_education")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdApplicationMainInfo")
                        .HasColumnName("id_application_main_info")
                        .HasColumnType("int");

                    b.Property<int>("IdCertificateType")
                        .HasColumnName("id_certificate_type")
                        .HasColumnType("int");

                    b.Property<int>("IdInstitutionType")
                        .HasColumnName("id_institution_type")
                        .HasColumnType("int");

                    b.Property<string>("InstitutionName")
                        .HasColumnName("institution_name")
                        .HasMaxLength(45)
                        .IsUnicode(false);

                    b.Property<int?>("Point")
                        .HasColumnName("point")
                        .HasColumnType("int");

                    b.HasKey("IdEducation");

                    b.HasIndex("IdApplicationMainInfo")
                        .HasName("fk_education_application_main_info1_idx");

                    b.HasIndex("IdCertificateType")
                        .HasName("fk_education_certificate_type1_idx");

                    b.HasIndex("IdInstitutionType")
                        .HasName("fk_education_institution_type1_idx");

                    b.ToTable("education","dbstud");
                });

            modelBuilder.Entity("StudCabinetREST.Models.Exam", b =>
                {
                    b.Property<int>("IdExams")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id_exams")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdApplicationMainInfo")
                        .HasColumnName("id_application_main_info")
                        .HasColumnType("int");

                    b.Property<int>("ObjectId")
                        .HasColumnName("object_id")
                        .HasColumnType("int");

                    b.Property<int?>("Point")
                        .HasColumnName("point")
                        .HasColumnType("int");

                    b.HasKey("IdExams");

                    b.HasIndex("IdApplicationMainInfo")
                        .HasName("fk_exam_applicatin_main_info1_idx");

                    b.HasIndex("ObjectId")
                        .HasName("fk_exam_object1_idx");

                    b.ToTable("exam","dbstud");
                });

            modelBuilder.Entity("StudCabinetREST.Models.Faculty", b =>
                {
                    b.Property<int>("IdFaculty")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id_faculty")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasMaxLength(45)
                        .IsUnicode(false);

                    b.HasKey("IdFaculty");

                    b.ToTable("faculty","dbstud");
                });

            modelBuilder.Entity("StudCabinetREST.Models.InstitutionType", b =>
                {
                    b.Property<int>("IdNstitutionType")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id_nstitution_type")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasMaxLength(45)
                        .IsUnicode(false);

                    b.HasKey("IdNstitutionType");

                    b.ToTable("institution_type","dbstud");
                });

            modelBuilder.Entity("StudCabinetREST.Models.Object", b =>
                {
                    b.Property<int>("ObjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("object_id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasMaxLength(45)
                        .IsUnicode(false);

                    b.HasKey("ObjectId");

                    b.ToTable("object","dbstud");
                });

            modelBuilder.Entity("StudCabinetREST.Models.Passport", b =>
                {
                    b.Property<int>("IdPassport")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id_passport")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DateOfIssue")
                        .HasColumnName("date_of_issue")
                        .HasColumnType("date");

                    b.Property<string>("Department")
                        .HasColumnName("department")
                        .HasMaxLength(45)
                        .IsUnicode(false);

                    b.Property<string>("Number")
                        .HasColumnName("number")
                        .HasMaxLength(45)
                        .IsUnicode(false);

                    b.Property<string>("Series")
                        .HasColumnName("series")
                        .HasMaxLength(45)
                        .IsUnicode(false);

                    b.HasKey("IdPassport");

                    b.ToTable("passport","dbstud");
                });

            modelBuilder.Entity("StudCabinetREST.Models.Privilege", b =>
                {
                    b.Property<int>("IdPrivilege")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id_privilege")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdApplicationMainInfo")
                        .HasColumnName("id_application_main")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasMaxLength(45)
                        .IsUnicode(false);

                    b.HasKey("IdPrivilege");

                    b.HasIndex("IdApplicationMainInfo")
                        .HasName("fk_privilege_application_main_info1_idx");

                    b.ToTable("privilege","dbstud");
                });

            modelBuilder.Entity("StudCabinetREST.Models.Reward", b =>
                {
                    b.Property<int>("IdAward")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id_award")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdApplicationMainInfo")
                        .HasColumnName("id_application_main_info")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasMaxLength(45)
                        .IsUnicode(false);

                    b.HasKey("IdAward");

                    b.HasIndex("IdApplicationMainInfo")
                        .HasName("fk_reward_application_main_info1_idx");

                    b.ToTable("reward","dbstud");
                });

            modelBuilder.Entity("StudCabinetREST.Models.Specialization", b =>
                {
                    b.Property<int>("IdSpecialization")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id_specialization")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasMaxLength(45)
                        .IsUnicode(false);

                    b.HasKey("IdSpecialization");

                    b.ToTable("specialization","dbstud");
                });

            modelBuilder.Entity("StudCabinetREST.Models.Status", b =>
                {
                    b.Property<int>("IdStatus")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id_status")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasMaxLength(45)
                        .IsUnicode(false);

                    b.HasKey("IdStatus");

                    b.ToTable("status","dbstud");
                });

            modelBuilder.Entity("StudCabinetREST.Models.Application", b =>
                {
                    b.HasOne("StudCabinetREST.Models.ApplicationMainInfo", "IdApplicationMainInfoNavigation")
                        .WithMany("Application")
                        .HasForeignKey("IdApplicationMainInfo")
                        .HasConstraintName("fk_application_application_main_info1");

                    b.HasOne("StudCabinetREST.Models.Direction", "IdDirectionNavigation")
                        .WithMany("Application")
                        .HasForeignKey("IdDirection")
                        .HasConstraintName("fk_application_direction1");

                    b.HasOne("StudCabinetREST.Models.Faculty", "IdFacultyNavigation")
                        .WithMany("Application")
                        .HasForeignKey("IdFaculty")
                        .HasConstraintName("fk_application_faculty1");

                    b.HasOne("StudCabinetREST.Models.Specialization", "IdSpecializationNavigation")
                        .WithMany("Application")
                        .HasForeignKey("IdSpecialization")
                        .HasConstraintName("fk_application_specialization1");
                });

            modelBuilder.Entity("StudCabinetREST.Models.ApplicationMainInfo", b =>
                {
                    b.HasOne("StudCabinetREST.Models.Passport", "IdPassportNavigation")
                        .WithMany("ApplicationMainInfo")
                        .HasForeignKey("IdPassport")
                        .HasConstraintName("fk_application_main_info_passport");

                    b.HasOne("StudCabinetREST.Models.Status", "StatusIdStatusNavigation")
                        .WithMany("ApplicationMainInfo")
                        .HasForeignKey("StatusIdStatus")
                        .HasConstraintName("fk_application_main_info_status1");
                });

            modelBuilder.Entity("StudCabinetREST.Models.Education", b =>
                {
                    b.HasOne("StudCabinetREST.Models.ApplicationMainInfo", "IdApplicationMainInfoNavigation")
                        .WithMany("Education")
                        .HasForeignKey("IdApplicationMainInfo")
                        .HasConstraintName("fk_education_application_main_info1");

                    b.HasOne("StudCabinetREST.Models.CertificateType", "IdCertificateTypeNavigation")
                        .WithMany("Education")
                        .HasForeignKey("IdCertificateType")
                        .HasConstraintName("fk_education_certificate_type1");

                    b.HasOne("StudCabinetREST.Models.InstitutionType", "IdInstitutionTypeNavigation")
                        .WithMany("Education")
                        .HasForeignKey("IdInstitutionType")
                        .HasConstraintName("fk_education_institution_type1");
                });

            modelBuilder.Entity("StudCabinetREST.Models.Exam", b =>
                {
                    b.HasOne("StudCabinetREST.Models.ApplicationMainInfo", "IdApplicationMainInfoNavigation")
                        .WithMany("Exam")
                        .HasForeignKey("IdApplicationMainInfo")
                        .HasConstraintName("fk_exam_application_main_info1");

                    b.HasOne("StudCabinetREST.Models.Object", "Object")
                        .WithMany("Exam")
                        .HasForeignKey("ObjectId")
                        .HasConstraintName("fk_exam_object1");
                });

            modelBuilder.Entity("StudCabinetREST.Models.Privilege", b =>
                {
                    b.HasOne("StudCabinetREST.Models.ApplicationMainInfo", "IdApplicationMainInfoNavigation")
                        .WithMany("Privilege")
                        .HasForeignKey("IdApplicationMainInfo")
                        .HasConstraintName("fk_privilege_application_main_info1");
                });

            modelBuilder.Entity("StudCabinetREST.Models.Reward", b =>
                {
                    b.HasOne("StudCabinetREST.Models.ApplicationMainInfo", "IdApplicationMainInfoNavigation")
                        .WithMany("Reward")
                        .HasForeignKey("IdApplicationMainInfo")
                        .HasConstraintName("fk_reward_application_main_info1");
                });
#pragma warning restore 612, 618
        }
    }
}
