using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Clinic_Managment_System.Models
{
    public partial class HospitalContext : DbContext
    {
        public HospitalContext()
        {
        }

        public HospitalContext(DbContextOptions<HospitalContext> options)
            : base(options)
        {
        }

        public virtual DbSet<PatientInfo> PatientInfos { get; set; } = null!;
        public virtual DbSet<PatientInfo1> PatientInfo1s { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=Hospital;Integrated Security=SSPI");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PatientInfo>(entity =>
            {
                entity.HasKey(e => e.PatientRegNo)
                    .HasName("PK__PatientI__8D5AD76639B50995");

                entity.ToTable("PatientInfo");

                entity.Property(e => e.Cholestrol)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FirstApdate)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("firstAPDate");

                entity.Property(e => e.FirstApfees).HasColumnName("FirstAPfees");

                entity.Property(e => e.Medicines)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.MobileNo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PatAddress)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PatBp)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("PatBP");

                entity.Property(e => e.PatName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Sugur)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("sugur");

                entity.Property(e => e.Wieght).HasColumnName("wieght");
            });

            modelBuilder.Entity<PatientInfo1>(entity =>
            {
                entity.HasKey(e => e.PatientRegNo)
                    .HasName("PK__PatientI__8D5AD76630CB8A46");

                entity.ToTable("PatientInfo1");

                entity.Property(e => e.PatientRegNo).ValueGeneratedOnAdd();

                entity.Property(e => e.NextDateAp)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.PatientRegNoNavigation)
                    .WithOne(p => p.PatientInfo1)
                    .HasForeignKey<PatientInfo1>(d => d.PatientRegNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PatientIn__Patie__32E0915F");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
