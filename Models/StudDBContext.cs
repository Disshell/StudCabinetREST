using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace StudCabinetREST.Models
{
    public class StudDBContext : DbContext
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
        public virtual DbSet<Privilege> Privileges { get; set; }
        public virtual DbSet<Reward> Reward { get; set; }
        public virtual DbSet<Specialization> Specialization { get; set; }
        public virtual DbSet<Military> Military { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-TPECO3Q\\SQLEXPRESS;Database=StudDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApplicationMainInfo>()
            .HasOne(a => a.Military)
            .WithOne(m => m.ApplicationMainInfo)
            .HasForeignKey<Military>(m => m.ApplicationMainInfoId);
        }
    }
}
