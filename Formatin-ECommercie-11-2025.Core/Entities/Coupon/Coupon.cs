using System;
using Formation_ECommerce_11_2025.Core.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Formation_ECommerce_11_2025.Core.Entities.Coupons;

	public class Coupon : BaseEntity
{
    [Required]
    [MaxLength(50)]
    public string CouponCode { get; set; }
    [Required]
    [Column(TypeName = "decimal(10,2)")]
    public decimal DiscountAmount { get; set; }
    public decimal Minimalaccount { get; set; }

}
	

