using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Dal_da1.DomainClass;

[PrimaryKey("MaSpct", "MaNhapHang")]
[Table("NhapHangChiTiet")]
public partial class NhapHangChiTiet
{
    [Key]
    [Column("MaSPCT")]
    [StringLength(10)]
    [Unicode(false)]
    public string MaSpct { get; set; } = null!;

    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string MaNhapHang { get; set; } = null!;

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? DonGia { get; set; }

    public int? SoLuong { get; set; }

    [ForeignKey("MaNhapHang")]
    [InverseProperty("NhapHangChiTiets")]
    public virtual NhapHang MaNhapHangNavigation { get; set; } = null!;

    [ForeignKey("MaSpct")]
    [InverseProperty("NhapHangChiTiets")]
    public virtual SanPhamChiTiet MaSpctNavigation { get; set; } = null!;
}
