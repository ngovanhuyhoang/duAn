using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Dal_da1.DomainClass;

[Table("ThuongHieu")]
public partial class ThuongHieu
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string MaThuongHieu { get; set; } = null!;

    [StringLength(50)]
    public string? TenThuongHieu { get; set; }

    [InverseProperty("MaThuongHieuNavigation")]
    public virtual ICollection<SanPhamChiTiet> SanPhamChiTiets { get; set; } = new List<SanPhamChiTiet>();
}
