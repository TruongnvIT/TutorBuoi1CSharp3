using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ThiThu4.Models
{
    public partial class ThiThu4Context : DbContext
    {
        public ThiThu4Context()
        {
        }

        public ThiThu4Context(DbContextOptions<ThiThu4Context> options)
            : base(options)
        {
        }

        public virtual DbSet<HangXe> HangXes { get; set; } = null!;
        public virtual DbSet<XeMay> XeMays { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-O3T64PD;Database=ThiThu4;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HangXe>(entity =>
            {
                entity.ToTable("HangXe");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.TenHangXe).HasMaxLength(50);
            });

            modelBuilder.Entity<XeMay>(entity =>
            {
                entity.ToTable("XeMay");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.MaXe)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.TenXe).HasMaxLength(50);

                entity.HasOne(d => d.IdHangXeNavigation)
                    .WithMany(p => p.XeMays)
                    .HasForeignKey(d => d.IdHangXe)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_XeMay_HangXe");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
