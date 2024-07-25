using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Dal_da1.DomainClass;

[Table("HoaDon")]
public partial class HoaDon
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string MaHoaDon { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? NgayTao { get; set; }

    [StringLength(200)]
    public string? GhiChu { get; set; }

    public int? TrangThai { get; set; }

    [Column("SDTKH")]
    [StringLength(15)]
    public string? Sdtkh { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? MaNhanVien { get; set; }

    [InverseProperty("MaHoaDonNavigation")]
    public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; } = new List<HoaDonChiTiet>();

    [ForeignKey("MaNhanVien")]
    [InverseProperty("HoaDons")]
    public virtual NhanVien? MaNhanVienNavigation { get; set; }

    [ForeignKey("Sdtkh")]
    [InverseProperty("HoaDons")]
    public virtual KhachHang? SdtkhNavigation { get; set; }
}
