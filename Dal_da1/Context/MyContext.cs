using System;
using System.Collections.Generic;
using Dal_da1.DomainClass;
using Microsoft.EntityFrameworkCore;

namespace Dal_da1.Context;

public partial class MyContext : DbContext
{
    public MyContext()
    {
    }

    public MyContext(DbContextOptions<MyContext> options)
        : base(options)
    {
    }

    public virtual DbSet<BaoCao> BaoCaos { get; set; }

    public virtual DbSet<ChucVu> ChucVus { get; set; }

    public virtual DbSet<DanhMuc> DanhMucs { get; set; }

    public virtual DbSet<HoaDon> HoaDons { get; set; }

    public virtual DbSet<HoaDonChiTiet> HoaDonChiTiets { get; set; }

    public virtual DbSet<KhachHang> KhachHangs { get; set; }

    public virtual DbSet<KhuyenMai> KhuyenMais { get; set; }

    public virtual DbSet<NhaCungCap> NhaCungCaps { get; set; }

    public virtual DbSet<NhanVien> NhanViens { get; set; }

    public virtual DbSet<NhapHang> NhapHangs { get; set; }

    public virtual DbSet<NhapHangChiTiet> NhapHangChiTiets { get; set; }

    public virtual DbSet<SanPham> SanPhams { get; set; }

    public virtual DbSet<SanPhamChiTiet> SanPhamChiTiets { get; set; }

    public virtual DbSet<ThuongHieu> ThuongHieus { get; set; }

    public virtual DbSet<Voucher> Vouchers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source= HOANG\\SQLEXPRESS ;Initial Catalog=DA1;Integrated Security=True;TrustServerCertificate=true\n");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BaoCao>(entity =>
        {
            entity.HasKey(e => e.MaBaoCao).HasName("PK__BaoCao__25A9188C8DC91091");

            entity.Property(e => e.NgayTao).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.MaNhanVienNavigation).WithMany(p => p.BaoCaos).HasConstraintName("FK__BaoCao__MaNhanVi__4A8310C6");
        });

        modelBuilder.Entity<ChucVu>(entity =>
        {
            entity.HasKey(e => e.TenChucVu).HasName("PK__ChucVu__A7E2123FF40C14C6");
        });

        modelBuilder.Entity<DanhMuc>(entity =>
        {
            entity.HasKey(e => e.MaDanhMuc).HasName("PK__DanhMuc__B37508879866E025");
        });

        modelBuilder.Entity<HoaDon>(entity =>
        {
            entity.HasKey(e => e.MaHoaDon).HasName("PK__HoaDon__835ED13B4C060D19");

            entity.Property(e => e.NgayTao).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.MaNhanVienNavigation).WithMany(p => p.HoaDons).HasConstraintName("FK__HoaDon__MaNhanVi__339FAB6E");

            entity.HasOne(d => d.SdtkhNavigation).WithMany(p => p.HoaDons).HasConstraintName("FK__HoaDon__SDTKH__32AB8735");
        });

        modelBuilder.Entity<HoaDonChiTiet>(entity =>
        {
            entity.HasKey(e => new { e.MaSpct, e.MaHoaDon }).HasName("PK__HoaDonCh__36E3C8545D933CEE");

            entity.HasOne(d => d.MaHoaDonNavigation).WithMany(p => p.HoaDonChiTiets)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__HoaDonChi__MaHoa__40058253");

            entity.HasOne(d => d.MaSpctNavigation).WithMany(p => p.HoaDonChiTiets)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__HoaDonChi__MaSPC__3F115E1A");
        });

        modelBuilder.Entity<KhachHang>(entity =>
        {
            entity.HasKey(e => e.Sdtkh).HasName("PK__KhachHan__DD0655648712E9DE");

            entity.Property(e => e.CreatedAt).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.MaVoucherNavigation).WithMany(p => p.KhachHangs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__KhachHang__MaVou__2EDAF651");
        });

        modelBuilder.Entity<KhuyenMai>(entity =>
        {
            entity.HasKey(e => e.MaKhuyenMai).HasName("PK__KhuyenMa__6F56B3BD54225EC9");
        });

        modelBuilder.Entity<NhaCungCap>(entity =>
        {
            entity.HasKey(e => e.MaNhaCungCap).HasName("PK__NhaCungC__53DA9205A4331F7F");
        });

        modelBuilder.Entity<NhanVien>(entity =>
        {
            entity.HasKey(e => e.MaNhanVien).HasName("PK__NhanVien__77B2CA47D14AA6BA");

            entity.Property(e => e.DaThoiViec).HasDefaultValue(false);
            entity.Property(e => e.NgayThue).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.TenChucVuNavigation).WithMany(p => p.NhanViens)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__NhanVien__TenChu__2739D489");
        });

        modelBuilder.Entity<NhapHang>(entity =>
        {
            entity.HasKey(e => e.MaNhapHang).HasName("PK__NhapHang__42ECBDEAA8E04B2E");

            entity.Property(e => e.NgayNhap).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.MaNhanVienNavigation).WithMany(p => p.NhapHangs).HasConstraintName("FK__NhapHang__MaNhan__42E1EEFE");
        });

        modelBuilder.Entity<NhapHangChiTiet>(entity =>
        {
            entity.HasKey(e => new { e.MaSpct, e.MaNhapHang }).HasName("PK__NhapHang__2AF8EE99229336EF");

            entity.HasOne(d => d.MaNhapHangNavigation).WithMany(p => p.NhapHangChiTiets)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__NhapHangC__MaNha__47A6A41B");

            entity.HasOne(d => d.MaSpctNavigation).WithMany(p => p.NhapHangChiTiets)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__NhapHangC__MaSPC__46B27FE2");
        });

        modelBuilder.Entity<SanPham>(entity =>
        {
            entity.HasKey(e => e.MaSanPham).HasName("PK__SanPham__FAC7442DB3A89CBF");

            entity.Property(e => e.NgayThem).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.NgungKinhDoanh).HasDefaultValue(false);
        });

        modelBuilder.Entity<SanPhamChiTiet>(entity =>
        {
            entity.HasKey(e => e.MaSpct).HasName("PK__SanPhamC__9ED62547A3BC2CCA");

            entity.HasOne(d => d.MaDanhMucNavigation).WithMany(p => p.SanPhamChiTiets).HasConstraintName("FK__SanPhamCh__MaDan__395884C4");

            entity.HasOne(d => d.MaKhuyenMaiNavigation).WithMany(p => p.SanPhamChiTiets)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__SanPhamCh__MaKhu__3C34F16F");

            entity.HasOne(d => d.MaNhaCungCapNavigation).WithMany(p => p.SanPhamChiTiets)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__SanPhamCh__MaNha__3B40CD36");

            entity.HasOne(d => d.MaSanPhamNavigation).WithMany(p => p.SanPhamChiTiets).HasConstraintName("FK__SanPhamCh__MaSan__3864608B");

            entity.HasOne(d => d.MaThuongHieuNavigation).WithMany(p => p.SanPhamChiTiets).HasConstraintName("FK__SanPhamCh__MaThu__3A4CA8FD");
        });

        modelBuilder.Entity<ThuongHieu>(entity =>
        {
            entity.HasKey(e => e.MaThuongHieu).HasName("PK__ThuongHi__A3733E2CA2AA50E1");
        });

        modelBuilder.Entity<Voucher>(entity =>
        {
            entity.HasKey(e => e.MaVoucher).HasName("PK__Voucher__0AAC5B11EBF0EE9D");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
