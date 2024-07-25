using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Dal_da1.DomainClass;

[Table("DanhMuc")]
public partial class DanhMuc
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string MaDanhMuc { get; set; } = null!;

    [StringLength(50)]
    public string? TenDanhMuc { get; set; }

    [InverseProperty("MaDanhMucNavigation")]
    public virtual ICollection<SanPhamChiTiet> SanPhamChiTiets { get; set; } = new List<SanPhamChiTiet>();
}
