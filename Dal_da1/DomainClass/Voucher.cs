using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Dal_da1.DomainClass;

[Table("Voucher")]
public partial class Voucher
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string MaVoucher { get; set; } = null!;

    [StringLength(100)]
    public string? TenVoucher { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? GiaTri { get; set; }

    public DateOnly? NgayBatDau { get; set; }

    public DateOnly? NgayKetThuc { get; set; }

    [InverseProperty("MaVoucherNavigation")]
    public virtual ICollection<KhachHang> KhachHangs { get; set; } = new List<KhachHang>();
}
