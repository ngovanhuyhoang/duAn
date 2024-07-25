using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Dal_da1.DomainClass;

[Table("NhaCungCap")]
public partial class NhaCungCap
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string MaNhaCungCap { get; set; } = null!;

    [StringLength(100)]
    public string? TenNhaCungCap { get; set; }

    [StringLength(200)]
    public string? DiaChi { get; set; }

    [Column("SDT")]
    [StringLength(15)]
    public string? Sdt { get; set; }

    [InverseProperty("MaNhaCungCapNavigation")]
    public virtual ICollection<SanPhamChiTiet> SanPhamChiTiets { get; set; } = new List<SanPhamChiTiet>();
}
