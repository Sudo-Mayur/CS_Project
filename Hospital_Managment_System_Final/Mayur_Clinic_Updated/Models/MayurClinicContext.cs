using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Mayur_Clinic_Updated.Models
{
    public partial class MayurClinicContext : DbContext
    {
        public MayurClinicContext()
        {
        }

        public MayurClinicContext(DbContextOptions<MayurClinicContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DailyCollection> DailyCollections { get; set; } = null!;
        public virtual DbSet<Patient> Patients { get; set; } = null!;
        public virtual DbSet<PatientInfo> PatientInfos { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=MayurClinic;Integrated Security=SSPI");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DailyCollection>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DailyCollection");

                entity.Property(e => e.Apdate)
                    .HasColumnType("date")
                    .HasColumnName("APDate");

                entity.Property(e => e.RecordNo).ValueGeneratedOnAdd();

                entity.HasOne(d => d.RecordNoNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.RecordNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DailyColl__Recor__2C3393D0");
            });

            modelBuilder.Entity<Patient>(entity =>
            {
                entity.HasKey(e => e.PatientRegNo)
                    .HasName("PK__Patient__8D5AD766C9C73485");

                entity.ToTable("Patient");

                entity.Property(e => e.MobileNo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PatAddress)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.PatName)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PatientInfo>(entity =>
            {
                entity.HasKey(e => e.RecordNo)
                    .HasName("PK__PatientI__FBDEAF5A31F23FF6");

                entity.ToTable("PatientInfo");

                entity.Property(e => e.Apdate)
                    .HasColumnType("date")
                    .HasColumnName("APDate");

                entity.Property(e => e.CholestrolHdl).HasColumnName("CholestrolHDL");

                entity.Property(e => e.CholestrolLdl).HasColumnName("CholestrolLDL");

                entity.Property(e => e.Fees).HasColumnName("fees");

                entity.Property(e => e.Medicines)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.MobileNo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PatAddress)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.PatBp).HasColumnName("PatBP");

                entity.Property(e => e.PatName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Wieght).HasColumnName("wieght");

                entity.HasOne(d => d.PatientRegNoNavigation)
                    .WithMany(p => p.PatientInfos)
                    .HasForeignKey(d => d.PatientRegNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PatientIn__Patie__2A4B4B5E");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
