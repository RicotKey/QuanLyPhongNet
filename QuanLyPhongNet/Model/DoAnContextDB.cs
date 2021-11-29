using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QuanLyPhongNet.Model
{
    public partial class DoAnContextDB : DbContext
    {
        public DoAnContextDB()
            : base("name=DoAnContextDB4")
        {
        }

        public virtual DbSet<May> Mays { get; set; }
        public virtual DbSet<NapTien> NapTiens { get; set; }
        public virtual DbSet<SuDung> SuDungs { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<May>()
                .Property(e => e.SoMay)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<May>()
                .HasMany(e => e.SuDungs)
                .WithRequired(e => e.May)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SuDung>()
                .Property(e => e.SoMay)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SuDung>()
                .Property(e => e.TrangThai)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.MatKhau)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoan>()
                .HasMany(e => e.SuDungs)
                .WithRequired(e => e.TaiKhoan)
                .WillCascadeOnDelete(false);
        }
    }
}
