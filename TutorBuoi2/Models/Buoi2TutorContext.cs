using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TutorBuoi2.Models
{
    public partial class Buoi2TutorContext : DbContext
    {
        public Buoi2TutorContext()
        {
        }

        public Buoi2TutorContext(DbContextOptions<Buoi2TutorContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ChucVu> ChucVus { get; set; } = null!;
        public virtual DbSet<ConNguoi> ConNguois { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-O3T64PD;Database=Buoi2Tutor;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChucVu>(entity =>
            {
                entity.ToTable("ChucVu");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ChucVu1)
                    .HasMaxLength(50)
                    .HasColumnName("ChucVu");
            });

            modelBuilder.Entity<ConNguoi>(entity =>
            {
                entity.ToTable("ConNguoi");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.DiaChi).HasMaxLength(50);

                entity.Property(e => e.GioiTinh).HasMaxLength(3);

                entity.Property(e => e.Ten).HasMaxLength(20);

                entity.HasOne(d => d.IdChucVuNavigation)
                    .WithMany(p => p.ConNguois)
                    .HasForeignKey(d => d.IdChucVu)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ConNguoi_ChucVu");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
