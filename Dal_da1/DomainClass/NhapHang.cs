using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Dal_da1.DomainClass;

[Table("NhapHang")]
public partial class NhapHang
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string MaNhapHang { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? MaNhanVien { get; set; }

    [StringLength(200)]
    public string? GhiChu { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? NgayNhap { get; set; }

    [ForeignKey("MaNhanVien")]
    [InverseProperty("NhapHangs")]
    public virtual NhanVien? MaNhanVienNavigation { get; set; }

    [InverseProperty("MaNhapHangNavigation")]
    public virtual ICollection<NhapHangChiTiet> NhapHangChiTiets { get; set; } = new List<NhapHangChiTiet>();
}
