using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TutorBuoi1CSharp3.Models
{
    public partial class Buoi1TutorContext : DbContext
    {
        public Buoi1TutorContext()
        {
        }

        public Buoi1TutorContext(DbContextOptions<Buoi1TutorContext> options)
            : base(options)
        {
        }

        public virtual DbSet<NguoiDung> NguoiDungs { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-O3T64PD;Database=Buoi1Tutor;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NguoiDung>(entity =>
            {
                entity.ToTable("NguoiDung");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.GiớiTính)
                    .HasMaxLength(3)
                    .HasColumnName("Giới Tính");

                entity.Property(e => e.Ten).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
