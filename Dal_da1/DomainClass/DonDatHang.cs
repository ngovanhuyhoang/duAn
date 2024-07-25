using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Dal_da1.DomainClass;

[Table("DonDatHang")]
public partial class DonDatHang
{
    [Key]
    public int MaDonDatHang { get; set; }

    public int? MaNhaCungCap { get; set; }

    public int? MaNhanVien { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? TongTien { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? NgayTao { get; set; }

    [InverseProperty("MaDonDatHangNavigation")]
    public virtual ICollection<ChiTietDonDatHang> ChiTietDonDatHangs { get; set; } = new List<ChiTietDonDatHang>();

    [ForeignKey("MaNhaCungCap")]
    [InverseProperty("DonDatHangs")]
    public virtual NhaCungCap? MaNhaCungCapNavigation { get; set; }

    [ForeignKey("MaNhanVien")]
    [InverseProperty("DonDatHangs")]
    public virtual NhanVien? MaNhanVienNavigation { get; set; }
}
