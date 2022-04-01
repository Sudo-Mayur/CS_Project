using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ASP_RazorViews.Models
{
    public partial class ApiDbContext : DbContext
    {
        public ApiDbContext()
        {
        }

        public ApiDbContext(DbContextOptions<ApiDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Categories { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<RequiestInfo> RequiestInfos { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=ApiDb;Integrated Security=SSPI");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(e => e.CategoryRowId);

                entity.Property(e => e.CategoryId).HasMaxLength(50);

                entity.Property(e => e.CategoryName).HasMaxLength(50);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.ProductRowId);

                entity.HasIndex(e => e.CategoryRowId, "IX_Products_CategoryRowId");

                entity.Property(e => e.Description).HasMaxLength(400);

                entity.Property(e => e.ProductId).HasMaxLength(50);

                entity.Property(e => e.ProductName).HasMaxLength(50);

                entity.HasOne(d => d.CategoryRow)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.CategoryRowId);
            });

            modelBuilder.Entity<RequiestInfo>(entity =>
            {
                entity.HasKey(e => e.RequiestId);

                entity.ToTable("requiestInfos");

                entity.Property(e => e.RequiestId).HasColumnName("RequiestID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
