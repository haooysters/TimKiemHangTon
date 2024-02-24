using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace TimKiemHangTon.Models
{
    public partial class db_KhoHangContext : DbContext
    {
        public db_KhoHangContext()
        {
        }

        public db_KhoHangContext(DbContextOptions<db_KhoHangContext> options)
            : base(options)
        {
        }

        public virtual DbSet<HangTon> HangTons { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=TRANVUHAO;Database=db_KhoHang;Integrated Security=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<HangTon>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HangTon");

                entity.Property(e => e.InspectionNo).HasMaxLength(50);

                entity.Property(e => e.MaHang).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
