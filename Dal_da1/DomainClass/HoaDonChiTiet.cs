using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Dal_da1.DomainClass;

[PrimaryKey("MaSpct", "MaHoaDon")]
[Table("HoaDonChiTiet")]
public partial class HoaDonChiTiet
{
    [Key]
    [Column("MaSPCT")]
    [StringLength(10)]
    [Unicode(false)]
    public string MaSpct { get; set; } = null!;

    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string MaHoaDon { get; set; } = null!;

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? DonGia { get; set; }

    public int? SoLuong { get; set; }

    [ForeignKey("MaHoaDon")]
    [InverseProperty("HoaDonChiTiets")]
    public virtual HoaDon MaHoaDonNavigation { get; set; } = null!;

    [ForeignKey("MaSpct")]
    [InverseProperty("HoaDonChiTiets")]
    public virtual SanPhamChiTiet MaSpctNavigation { get; set; } = null!;
}
