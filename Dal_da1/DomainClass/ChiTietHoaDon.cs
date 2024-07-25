using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Dal_da1.DomainClass;

[Table("ChiTietHoaDon")]
public partial class ChiTietHoaDon
{
    [Key]
    public int MaChiTietHoaDon { get; set; }

    public int? MaHoaDon { get; set; }

    public int? SanPham { get; set; }

    public int? SoLuong { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? DonGia { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? GiamGia { get; set; }

    [ForeignKey("MaHoaDon")]
    [InverseProperty("ChiTietHoaDons")]
    public virtual HoaDon? MaHoaDonNavigation { get; set; }

    [ForeignKey("MaSanPham")]
    [InverseProperty("ChiTietHoaDons")]
    public virtual SanPham? MaSanPhamNavigation { get; set; }
}
