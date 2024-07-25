using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Dal_da1.DomainClass;

[Table("NhanVien")]
public partial class NhanVien
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string MaNhanVien { get; set; } = null!;

    [StringLength(50)]
    public string? Username { get; set; }

    [StringLength(50)]
    public string? Password { get; set; }

    [StringLength(100)]
    public string? TenNhanVien { get; set; }

    [Column("SDT")]
    [StringLength(15)]
    public string? Sdt { get; set; }

    public DateOnly? NgaySinh { get; set; }

    [StringLength(200)]
    public string? DiaChi { get; set; }

    [StringLength(50)]
    public string TenChucVu { get; set; } = null!;

    public bool? DaThoiViec { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? NgayThue { get; set; }

    [InverseProperty("MaNhanVienNavigation")]
    public virtual ICollection<BaoCao> BaoCaos { get; set; } = new List<BaoCao>();

    [InverseProperty("MaNhanVienNavigation")]
    public virtual ICollection<HoaDon> HoaDons { get; set; } = new List<HoaDon>();

    [InverseProperty("MaNhanVienNavigation")]
    public virtual ICollection<NhapHang> NhapHangs { get; set; } = new List<NhapHang>();

    [ForeignKey("TenChucVu")]
    [InverseProperty("NhanViens")]
    public virtual ChucVu TenChucVuNavigation { get; set; } = null!;
}
