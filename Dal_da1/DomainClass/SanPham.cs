using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Dal_da1.DomainClass;

[Table("SanPham")]
public partial class SanPham
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string MaSanPham { get; set; } = null!;

    [StringLength(100)]
    public string? TenSanPham { get; set; }

    [StringLength(500)]
    public string? MoTa { get; set; }

    public bool? NgungKinhDoanh { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? NgayThem { get; set; }

    [InverseProperty("MaSanPhamNavigation")]
    public virtual ICollection<SanPhamChiTiet> SanPhamChiTiets { get; set; } = new List<SanPhamChiTiet>();
}
