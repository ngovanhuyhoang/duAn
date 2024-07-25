using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Dal_da1.DomainClass;

[Table("BaoCao")]
public partial class BaoCao
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string MaBaoCao { get; set; } = null!;

    [StringLength(50)]
    public string? LoaiBaoCao { get; set; }

    public string? NoiDung { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? MaNhanVien { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? NgayTao { get; set; }

    [ForeignKey("MaNhanVien")]
    [InverseProperty("BaoCaos")]
    public virtual NhanVien? MaNhanVienNavigation { get; set; }
}
