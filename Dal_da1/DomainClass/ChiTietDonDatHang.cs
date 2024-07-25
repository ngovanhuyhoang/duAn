using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Dal_da1.DomainClass;

[Table("ChiTietDonDatHang")]
public partial class ChiTietDonDatHang
{
    [Key]
    public int MaChiTietDonDatHang { get; set; }

    public int? MaDonDatHang { get; set; }

    public int? MaSanPham { get; set; }

    public int? SoLuong { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? DonGia { get; set; }

    [ForeignKey("MaDonDatHang")]
    [InverseProperty("ChiTietDonDatHangs")]
    public virtual DonDatHang? MaDonDatHangNavigation { get; set; }

    [ForeignKey("MaSanPham")]
    [InverseProperty("ChiTietDonDatHangs")]
    public virtual SanPham? MaSanPhamNavigation { get; set; }
}
