using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Dal_da1.DomainClass;

[Table("ChucVu")]
public partial class ChucVu
{
    [StringLength(10)]
    [Unicode(false)]
    public string MaChucVu { get; set; } = null!;

    [Key]
    [StringLength(50)]
    public string TenChucVu { get; set; } = null!;

    [InverseProperty("TenChucVuNavigation")]
    public virtual ICollection<NhanVien> NhanViens { get; set; } = new List<NhanVien>();
}
