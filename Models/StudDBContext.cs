using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace StudCabinetREST.Models
{
    public partial class StudDBContext : DbContext
    {
        public StudDBContext()
        {
        }

        public StudDBContext(DbContextOptions<StudDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Application> Application { get; set; }
        public virtual DbSet<ApplicationMainInfo> ApplicationMainInfo { get; set; }
        public virtual DbSet<CertificateType> CertificateType { get; set; }
        public virtual DbSet<Direction> Direction { get; set; }
        public virtual DbSet<Education> Education { get; set; }
        public virtual DbSet<Exam> Exam { get; set; }
        public virtual DbSet<Faculty> Faculty { get; set; }
        public virtual DbSet<InstitutionType> InstitutionType { get; set; }
        public virtual DbSet<Object> Object { get; set; }
        public virtual DbSet<Passport> Passport { get; set; }
        public virtual DbSet<Privileges> Privileges { get; set; }
        public virtual DbSet<Reward> Reward { get; set; }
        public virtual DbSet<Specialization> Specialization { get; set; }
        public virtual DbSet<Status> Status { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=StudDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Application>(entity =>
            {
                entity.HasKey(e => e.IdApplication);

                entity.ToTable("application", "dbstud");

                entity.HasIndex(e => e.IdDirection)
                    .HasName("fk_application_direction1_idx");

                entity.HasIndex(e => e.IdFaculty)
                    .HasName("fk_application_faculty1_idx");

                entity.HasIndex(e => e.IdSpecialization)
                    .HasName("fk_application_specialization1_idx");

                entity.HasIndex(e => e.IdStudentInfo)
                    .HasName("fk_application_student_info1_idx");

                entity.Property(e => e.IdApplication)
                    .HasColumnName("id_application")
                    .HasColumnType("int");

                entity.Property(e => e.IdDirection)
                    .HasColumnName("id_direction")
                    .HasColumnType("int");

                entity.Property(e => e.IdFaculty)
                    .HasColumnName("id_faculty")
                    .HasColumnType("int");

                entity.Property(e => e.IdSpecialization)
                    .HasColumnName("id_specialization")
                    .HasColumnType("int");

                entity.Property(e => e.IdStudentInfo)
                    .HasColumnName("id_student_info")
                    .HasColumnType("int");

                entity.HasOne(d => d.IdDirectionNavigation)
                    .WithMany(p => p.Application)
                    .HasForeignKey(d => d.IdDirection)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_application_direction1");

                entity.HasOne(d => d.IdFacultyNavigation)
                    .WithMany(p => p.Application)
                    .HasForeignKey(d => d.IdFaculty)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_application_faculty1");

                entity.HasOne(d => d.IdSpecializationNavigation)
                    .WithMany(p => p.Application)
                    .HasForeignKey(d => d.IdSpecialization)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_application_specialization1");

                entity.HasOne(d => d.IdStudentInfoNavigation)
                    .WithMany(p => p.Application)
                    .HasForeignKey(d => d.IdStudentInfo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_application_student_info1");
            });

            modelBuilder.Entity<ApplicationMainInfo>(entity =>
            {
                entity.HasKey(e => e.IdStudentInfo);

                entity.ToTable("application_main_info", "dbstud");

                entity.HasIndex(e => e.IdPassport)
                    .HasName("fk_student_info_passport_idx");

                entity.HasIndex(e => e.StatusIdStatus)
                    .HasName("fk_application_main_info_status1_idx");

                entity.Property(e => e.IdStudentInfo)
                    .HasColumnName("id_student_info")
                    .HasColumnType("int");

                entity.Property(e => e.AddressFact)
                    .HasColumnName("address_fact")
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.AddressPasport)
                    .HasColumnName("address_pasport")
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.Birthplace)
                    .HasColumnName("birthplace")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Citizenship)
                    .HasColumnName("citizenship")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.DateOfApplication)
                    .HasColumnName("date_of_application")
                    .HasColumnType("date");

                entity.Property(e => e.DateOfBirth)
                    .HasColumnName("date_of_birth")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasColumnName("gender")
                    .HasColumnType("tinyint");

                entity.Property(e => e.IdPassport)
                    .HasColumnName("id_passport")
                    .HasColumnType("int");

                entity.Property(e => e.Language)
                    .HasColumnName("language")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleName)
                    .HasColumnName("middle_name")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.NeedOfHostel)
                    .HasColumnName("need_of_hostel")
                    .HasColumnType("tinyint");

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneHome)
                    .HasColumnName("phone_home")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.StatusIdStatus)
                    .HasColumnName("status_id_status")
                    .HasColumnType("int");

                entity.Property(e => e.StudentInfocol)
                    .HasColumnName("student_infocol")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.StudentInfocol1)
                    .HasColumnName("student_infocol1")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Surename)
                    .HasColumnName("surename")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdPassportNavigation)
                    .WithMany(p => p.ApplicationMainInfo)
                    .HasForeignKey(d => d.IdPassport)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_student_info_passport");

                entity.HasOne(d => d.StatusIdStatusNavigation)
                    .WithMany(p => p.ApplicationMainInfo)
                    .HasForeignKey(d => d.StatusIdStatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_application_main_info_status1");
            });

            modelBuilder.Entity<CertificateType>(entity =>
            {
                entity.HasKey(e => e.IdCertificateType);

                entity.ToTable("certificate_type", "dbstud");

                entity.Property(e => e.IdCertificateType)
                    .HasColumnName("id_certificate_type")
                    .HasColumnType("int");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Direction>(entity =>
            {
                entity.HasKey(e => e.IdDirection);

                entity.ToTable("direction", "dbstud");

                entity.Property(e => e.IdDirection)
                    .HasColumnName("id_direction")
                    .HasColumnType("int");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Education>(entity =>
            {
                entity.HasKey(e => e.IdEducation);

                entity.ToTable("education", "dbstud");

                entity.HasIndex(e => e.IdCertificateType)
                    .HasName("fk_education_certificate_type1_idx");

                entity.HasIndex(e => e.IdInstitutionType)
                    .HasName("fk_education_institution_type1_idx");

                entity.HasIndex(e => e.IdStudentInfo)
                    .HasName("fk_education_student_info1_idx");

                entity.Property(e => e.IdEducation)
                    .HasColumnName("id_education")
                    .HasColumnType("int");

                entity.Property(e => e.IdCertificateType)
                    .HasColumnName("id_certificate_type")
                    .HasColumnType("int");

                entity.Property(e => e.IdInstitutionType)
                    .HasColumnName("id_institution_type")
                    .HasColumnType("int");

                entity.Property(e => e.IdStudentInfo)
                    .HasColumnName("id_student_info")
                    .HasColumnType("int");

                entity.Property(e => e.InstitutionName)
                    .HasColumnName("institution_name")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Point)
                    .HasColumnName("point")
                    .HasColumnType("int");

                entity.HasOne(d => d.IdCertificateTypeNavigation)
                    .WithMany(p => p.Education)
                    .HasForeignKey(d => d.IdCertificateType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_education_certificate_type1");

                entity.HasOne(d => d.IdInstitutionTypeNavigation)
                    .WithMany(p => p.Education)
                    .HasForeignKey(d => d.IdInstitutionType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_education_institution_type1");

                entity.HasOne(d => d.IdStudentInfoNavigation)
                    .WithMany(p => p.Education)
                    .HasForeignKey(d => d.IdStudentInfo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_education_student_info1");
            });

            modelBuilder.Entity<Exam>(entity =>
            {
                entity.HasKey(e => e.IdExams);

                entity.ToTable("exam", "dbstud");

                entity.HasIndex(e => e.IdStudentInfo)
                    .HasName("fk_exam_student_info1_idx");

                entity.HasIndex(e => e.ObjectId)
                    .HasName("fk_exam_object1_idx");

                entity.Property(e => e.IdExams)
                    .HasColumnName("id_exams")
                    .HasColumnType("int");

                entity.Property(e => e.Examcol)
                    .HasColumnName("examcol")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.IdStudentInfo)
                    .HasColumnName("id_student_info")
                    .HasColumnType("int");

                entity.Property(e => e.ObjectId)
                    .HasColumnName("object_id")
                    .HasColumnType("int");

                entity.Property(e => e.Point)
                    .HasColumnName("point")
                    .HasColumnType("int");

                entity.HasOne(d => d.IdStudentInfoNavigation)
                    .WithMany(p => p.Exam)
                    .HasForeignKey(d => d.IdStudentInfo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_exam_student_info1");

                entity.HasOne(d => d.Object)
                    .WithMany(p => p.Exam)
                    .HasForeignKey(d => d.ObjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_exam_object1");
            });

            modelBuilder.Entity<Faculty>(entity =>
            {
                entity.HasKey(e => e.IdFaculty);

                entity.ToTable("faculty", "dbstud");

                entity.Property(e => e.IdFaculty)
                    .HasColumnName("id_faculty")
                    .HasColumnType("int");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InstitutionType>(entity =>
            {
                entity.HasKey(e => e.IdNstitutionType);

                entity.ToTable("institution_type", "dbstud");

                entity.Property(e => e.IdNstitutionType)
                    .HasColumnName("id_nstitution_type")
                    .HasColumnType("int");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Object>(entity =>
            {
                entity.ToTable("object", "dbstud");

                entity.Property(e => e.ObjectId)
                    .HasColumnName("object_id")
                    .HasColumnType("int");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Passport>(entity =>
            {
                entity.HasKey(e => e.IdPassport);

                entity.ToTable("passport", "dbstud");

                entity.Property(e => e.IdPassport)
                    .HasColumnName("id_passport")
                    .HasColumnType("int");

                entity.Property(e => e.DateOfIssue)
                    .HasColumnName("date_of_issue")
                    .HasColumnType("date");

                entity.Property(e => e.Department)
                    .HasColumnName("department")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Number)
                    .HasColumnName("number")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Series)
                    .HasColumnName("series")
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Privileges>(entity =>
            {
                entity.HasKey(e => e.IdPrivileges);

                entity.ToTable("privileges", "dbstud");

                entity.HasIndex(e => e.IdStudentInfo)
                    .HasName("fk_privileges_student_info1_idx");

                entity.Property(e => e.IdPrivileges)
                    .HasColumnName("id_privileges")
                    .HasColumnType("int");

                entity.Property(e => e.IdStudentInfo)
                    .HasColumnName("id_student_info")
                    .HasColumnType("int");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdStudentInfoNavigation)
                    .WithMany(p => p.Privileges)
                    .HasForeignKey(d => d.IdStudentInfo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_privileges_student_info1");
            });

            modelBuilder.Entity<Reward>(entity =>
            {
                entity.HasKey(e => e.IdAward);

                entity.ToTable("reward", "dbstud");

                entity.HasIndex(e => e.IdStudentInfo)
                    .HasName("fk_reward_student_info1_idx");

                entity.Property(e => e.IdAward)
                    .HasColumnName("id_award")
                    .HasColumnType("int");

                entity.Property(e => e.IdStudentInfo)
                    .HasColumnName("id_student_info")
                    .HasColumnType("int");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdStudentInfoNavigation)
                    .WithMany(p => p.Reward)
                    .HasForeignKey(d => d.IdStudentInfo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_reward_student_info1");
            });

            modelBuilder.Entity<Specialization>(entity =>
            {
                entity.HasKey(e => e.IdSpecialization);

                entity.ToTable("specialization", "dbstud");

                entity.Property(e => e.IdSpecialization)
                    .HasColumnName("id_specialization")
                    .HasColumnType("int");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.HasKey(e => e.IdStatus);

                entity.ToTable("status", "dbstud");

                entity.Property(e => e.IdStatus)
                    .HasColumnName("id_status")
                    .HasColumnType("int");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });
        }
    }
}
