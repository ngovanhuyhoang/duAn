using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Dal_da1.DomainClass;

[Table("KhachHang")]
public partial class KhachHang
{
    [Key]
    [Column("SDTKH")]
    [StringLength(15)]
    public string Sdtkh { get; set; } = null!;

    [StringLength(100)]
    public string? TenKhachHang { get; set; }

    public DateOnly? NgaySinh { get; set; }

    [StringLength(200)]
    public string? DiaChi { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedAt { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string MaVoucher { get; set; } = null!;

    [InverseProperty("SdtkhNavigation")]
    public virtual ICollection<HoaDon> HoaDons { get; set; } = new List<HoaDon>();

    [ForeignKey("MaVoucher")]
    [InverseProperty("KhachHangs")]
    public virtual Voucher MaVoucherNavigation { get; set; } = null!;
}
