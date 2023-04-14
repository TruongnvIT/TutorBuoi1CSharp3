using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TutorBuoiCuoi.Models
{
    public partial class ThiThuCSharp3BuoiCuoiContext : DbContext
    {
        public ThiThuCSharp3BuoiCuoiContext()
        {
        }

        public ThiThuCSharp3BuoiCuoiContext(DbContextOptions<ThiThuCSharp3BuoiCuoiContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Sach> Sachs { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-O3T64PD;Database=ThiThuCSharp3BuoiCuoi;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sach>(entity =>
            {
                entity.ToTable("Sach");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Ma)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.NhaXb)
                    .HasMaxLength(50)
                    .HasColumnName("NhaXB");

                entity.Property(e => e.TenSach).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
