using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Hospital_Managment_System_Final.Models
{
    public partial class NewHospitalContext : DbContext
    {
        public NewHospitalContext()
        {
        }

        public NewHospitalContext(DbContextOptions<NewHospitalContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DailyCollection> DailyCollections { get; set; } = null!;
        public virtual DbSet<PatientInfo> PatientInfos { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=NewHospital;Integrated Security=SSPI");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DailyCollection>(entity =>
            {
                entity.HasKey(e => e.RecordNo)
                    .HasName("PK__DailyCol__FBDEAF5A60F00089");

                entity.ToTable("DailyCollection");

                entity.Property(e => e.Apdate)
                    .HasColumnType("date")
                    .HasColumnName("APDate");

                entity.HasOne(d => d.PatientRegNoNavigation)
                    .WithMany(p => p.DailyCollections)
                    .HasForeignKey(d => d.PatientRegNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DailyColl__Patie__5EBF139D");
            });

            modelBuilder.Entity<PatientInfo>(entity =>
            {
                entity.HasKey(e => e.PatientRegNo)
                    .HasName("PK__PatientI__8D5AD766932F40C0");

                entity.ToTable("PatientInfo");

                entity.Property(e => e.PatientRegNo).ValueGeneratedNever();

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

                entity.Property(e => e.RecordNo).ValueGeneratedOnAdd();

                entity.Property(e => e.Wieght).HasColumnName("wieght");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
