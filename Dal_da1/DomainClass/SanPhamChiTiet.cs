using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Dal_da1.DomainClass;

[Table("SanPhamChiTiet")]
public partial class SanPhamChiTiet
{
    [Key]
    [Column("MaSPCT")]
    [StringLength(10)]
    [Unicode(false)]
    public string MaSpct { get; set; } = null!;

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? DonGia { get; set; }

    public int? SoLuong { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string MaKhuyenMai { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? MaSanPham { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? MaDanhMuc { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? MaThuongHieu { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string MaNhaCungCap { get; set; } = null!;

    [InverseProperty("MaSpctNavigation")]
    public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; } = new List<HoaDonChiTiet>();

    [ForeignKey("MaDanhMuc")]
    [InverseProperty("SanPhamChiTiets")]
    public virtual DanhMuc? MaDanhMucNavigation { get; set; }

    [ForeignKey("MaKhuyenMai")]
    [InverseProperty("SanPhamChiTiets")]
    public virtual KhuyenMai MaKhuyenMaiNavigation { get; set; } = null!;

    [ForeignKey("MaNhaCungCap")]
    [InverseProperty("SanPhamChiTiets")]
    public virtual NhaCungCap MaNhaCungCapNavigation { get; set; } = null!;

    [ForeignKey("MaSanPham")]
    [InverseProperty("SanPhamChiTiets")]
    public virtual SanPham? MaSanPhamNavigation { get; set; }

    [ForeignKey("MaThuongHieu")]
    [InverseProperty("SanPhamChiTiets")]
    public virtual ThuongHieu? MaThuongHieuNavigation { get; set; }

    [InverseProperty("MaSpctNavigation")]
    public virtual ICollection<NhapHangChiTiet> NhapHangChiTiets { get; set; } = new List<NhapHangChiTiet>();
}
