using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Formation_ECommerce_11_2025.Core.Common;
using Formation_ECommerce_11_2025.Core.Entities.Identity;
using Formation_ECommerce_11_2025.Core.Entities.Coupons;

namespace Formation_ECommerce_11_2025.Core.Entities.Cart;



public class CartHeader: BaseEntity
{
	[Required]
	[ForeignKey("User")]
	public Guid UserId { get; set; }

	[ForeignKey("Coupon")]
	public string? CouponId { get; set; }
	public string? CouponCode { get; set; }


	public ApplicationUser User { get; set; }
    public Coupon Coupon{ get; set; }
	public ICollection<CartDetails> CartDetails { get; set; }

}

