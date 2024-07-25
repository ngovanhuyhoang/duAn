using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Dal_da1.DomainClass;

[Table("KhuyenMai")]
public partial class KhuyenMai
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string MaKhuyenMai { get; set; } = null!;

    [StringLength(100)]
    public string? TenKhuyenMai { get; set; }

    [Column(TypeName = "decimal(5, 2)")]
    public decimal? TyLeGiam { get; set; }

    public DateOnly? NgayBatDau { get; set; }

    public DateOnly? NgayKetThuc { get; set; }

    [InverseProperty("MaKhuyenMaiNavigation")]
    public virtual ICollection<SanPhamChiTiet> SanPhamChiTiets { get; set; } = new List<SanPhamChiTiet>();
}
