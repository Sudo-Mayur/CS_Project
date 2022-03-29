using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Web_App_Job_Seeker.Models
{
    public partial class CompanyContext : DbContext
    {
        public CompanyContext()
        {
        }

        public CompanyContext(DbContextOptions<CompanyContext> options)
            : base(options)
        {
        }

        public virtual DbSet<EducationalInfo> EducationalInfos { get; set; }
        public virtual DbSet<PersonalInfo> PersonalInfos { get; set; }
        public virtual DbSet<ProfessionalInfo> ProfessionalInfos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=Company;Integrated Security=SSPI");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EducationalInfo>(entity =>
            {
                entity.HasKey(e => e.EducationId)
                    .HasName("PK__Educatio__4BBE38E5B11CD673");

                entity.ToTable("EducationalInfo");

                entity.Property(e => e.EducationId).HasColumnName("EducationID");

                entity.Property(e => e.DegreeUniversityName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DiplomaBoardName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.HighestQuaification)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.HscboardName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("HSCBoardName");

                entity.Property(e => e.HscpassingYear).HasColumnName("HSCPassingYear");

                entity.Property(e => e.Hscpercentage).HasColumnName("HSCPercentage");

                entity.Property(e => e.MastersUniversityName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SscboardName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("SSCBoardName");

                entity.Property(e => e.SscpassingYear).HasColumnName("SSCPassingYear");

                entity.Property(e => e.Sscpercentage).HasColumnName("SSCPercentage");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.EducationalInfos)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Education__Perso__44FF419A");
            });

            modelBuilder.Entity<PersonalInfo>(entity =>
            {
                entity.HasKey(e => e.PersonId)
                    .HasName("PK__Personal__AA2FFBE573DC3B5E");

                entity.ToTable("PersonalInfo");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNo)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ImageFilePath)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ProfileFilePath)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProfessionalInfo>(entity =>
            {
                entity.HasKey(e => e.ProfessionalId)
                    .HasName("PK__Professi__B242EFA87B10F625");

                entity.ToTable("ProfessionalInfo");

                entity.Property(e => e.Companies)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectInfo)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.WorkExperience)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.ProfessionalInfos)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Professio__Perso__47DBAE45");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
