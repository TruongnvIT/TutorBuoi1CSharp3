using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Buoi3TuorThiThu.Models
{
    public partial class TutorCSharp3_ThiThub1Context : DbContext
    {
        public TutorCSharp3_ThiThub1Context()
        {
        }

        public TutorCSharp3_ThiThub1Context(DbContextOptions<TutorCSharp3_ThiThub1Context> options)
            : base(options)
        {
        }

        public virtual DbSet<LoaiXe> LoaiXes { get; set; } = null!;
        public virtual DbSet<XeMay> XeMays { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-O3T64PD;Database=TutorCSharp3_ThiThub1;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LoaiXe>(entity =>
            {
                entity.ToTable("LoaiXe");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.TenLoaiXe).HasMaxLength(50);
            });

            modelBuilder.Entity<XeMay>(entity =>
            {
                entity.ToTable("XeMay");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.IdLoaiXm).HasColumnName("IdLoaiXM");

                entity.Property(e => e.MoTa).HasMaxLength(50);

                entity.Property(e => e.TenXe).HasMaxLength(50);

                entity.HasOne(d => d.IdLoaiXmNavigation)
                    .WithMany(p => p.XeMays)
                    .HasForeignKey(d => d.IdLoaiXm)
                    .HasConstraintName("FK_XeMay_LoaiXe");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
