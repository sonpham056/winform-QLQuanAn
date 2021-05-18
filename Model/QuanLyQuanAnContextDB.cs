using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QuanLyQuanAn.Model
{
    public partial class QuanLyQuanAnContextDB : DbContext
    {
        public QuanLyQuanAnContextDB()
            : base("name=QuanLyQuanAnContextDB")
        {
        }

        public virtual DbSet<Ban> Bans { get; set; }
        public virtual DbSet<BangChamCong> BangChamCongs { get; set; }
        public virtual DbSet<CTBan> CTBans { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<LoaiMonAn> LoaiMonAns { get; set; }
        public virtual DbSet<MonAn> MonAns { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<PhieuDatBan> PhieuDatBans { get; set; }
        public virtual DbSet<TaiKhoanKH> TaiKhoanKHs { get; set; }
        public virtual DbSet<TaiKhoanNV> TaiKhoanNVs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ban>()
                .Property(e => e.MaBan)
                .IsUnicode(false);

            modelBuilder.Entity<Ban>()
                .HasMany(e => e.CTBans)
                .WithRequired(e => e.Ban)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Ban>()
                .HasMany(e => e.PhieuDatBans)
                .WithRequired(e => e.Ban)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BangChamCong>()
                .Property(e => e.MaNV)
                .IsUnicode(false);

            modelBuilder.Entity<CTBan>()
                .Property(e => e.MaHD)
                .IsUnicode(false);

            modelBuilder.Entity<CTBan>()
                .Property(e => e.MaMA)
                .IsUnicode(false);

            modelBuilder.Entity<CTBan>()
                .Property(e => e.MaBan)
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.MaHD)
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.TongTien)
                .HasPrecision(18, 0);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.MaNV)
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .HasMany(e => e.CTBans)
                .WithRequired(e => e.HoaDon)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.MaKH)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .HasMany(e => e.PhieuDatBans)
                .WithRequired(e => e.KhachHang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KhachHang>()
                .HasOptional(e => e.TaiKhoanKH)
                .WithRequired(e => e.KhachHang);

            modelBuilder.Entity<LoaiMonAn>()
                .Property(e => e.MaLoaiMonAn)
                .IsUnicode(false);

            modelBuilder.Entity<LoaiMonAn>()
                .HasMany(e => e.MonAns)
                .WithRequired(e => e.LoaiMonAn)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MonAn>()
                .Property(e => e.MaMA)
                .IsUnicode(false);

            modelBuilder.Entity<MonAn>()
                .Property(e => e.GiaTien)
                .HasPrecision(18, 0);

            modelBuilder.Entity<MonAn>()
                .Property(e => e.MaLoaiMonAn)
                .IsUnicode(false);

            modelBuilder.Entity<MonAn>()
                .HasMany(e => e.CTBans)
                .WithRequired(e => e.MonAn)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.MaNV)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.BangChamCongs)
                .WithRequired(e => e.NhanVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.HoaDons)
                .WithRequired(e => e.NhanVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.PhieuDatBans)
                .WithRequired(e => e.NhanVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NhanVien>()
                .HasOptional(e => e.TaiKhoanNV)
                .WithRequired(e => e.NhanVien);

            modelBuilder.Entity<PhieuDatBan>()
                .Property(e => e.MaNV)
                .IsUnicode(false);

            modelBuilder.Entity<PhieuDatBan>()
                .Property(e => e.MaKH)
                .IsUnicode(false);

            modelBuilder.Entity<PhieuDatBan>()
                .Property(e => e.MaBan)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoanKH>()
                .Property(e => e.MaKH)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoanKH>()
                .Property(e => e.MK)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoanNV>()
                .Property(e => e.MaNV)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoanNV>()
                .Property(e => e.MK)
                .IsUnicode(false);
        }
    }
}
