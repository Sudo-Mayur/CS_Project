﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Restaurant_Billing_System_New.Models
{
    public partial class restaurantContext : DbContext
    {
        public restaurantContext()
        {
        }

        public restaurantContext(DbContextOptions<restaurantContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Bill> Bills { get; set; } = null!;
        public virtual DbSet<CustomorInfo> CustomorInfos { get; set; } = null!;
        public virtual DbSet<Dish> Dishes { get; set; } = null!;
        public virtual DbSet<DishInfo> DishInfos { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=restaurant;Integrated Security=SSPI");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bill>(entity =>
            {
                entity.HasKey(e => e.BillNo)
                    .HasName("PK__Bill__11F28419018CEC20");

                entity.ToTable("Bill");

                entity.Property(e => e.CustName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CustomorId).HasColumnName("CustomorID");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.MobileNo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentMode)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.Customor)
                    .WithMany(p => p.Bills)
                    .HasForeignKey(d => d.CustomorId)
                    .HasConstraintName("FK__Bill__CustomorID__6E01572D");
            });

            modelBuilder.Entity<CustomorInfo>(entity =>
            {
                entity.HasKey(e => e.CustomorId)
                    .HasName("PK__Customor__39C6DEFBB888BE03");

                entity.ToTable("CustomorInfo");

                entity.Property(e => e.CustomorId).HasColumnName("CustomorID");

                entity.Property(e => e.CustName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.MobileNo)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Dish>(entity =>
            {
                entity.HasKey(e => e.DishNo)
                    .HasName("PK__Dish__188327BB5706A4F5");

                entity.ToTable("Dish");

                entity.Property(e => e.DishName)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DishInfo>(entity =>
            {
                entity.HasKey(e => e.LogId)
                    .HasName("PK__DishInfo__5E5499A8AC339CAB");

                entity.ToTable("DishInfo");

                entity.Property(e => e.LogId).HasColumnName("LogID");

                entity.Property(e => e.CustomorId).HasColumnName("CustomorID");

                entity.Property(e => e.DishName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.Customor)
                    .WithMany(p => p.DishInfos)
                    .HasForeignKey(d => d.CustomorId)
                    .HasConstraintName("FK__DishInfo__Custom__6A30C649");

                entity.HasOne(d => d.DishNoNavigation)
                    .WithMany(p => p.DishInfos)
                    .HasForeignKey(d => d.DishNo)
                    .HasConstraintName("FK__DishInfo__DishNo__6B24EA82");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
