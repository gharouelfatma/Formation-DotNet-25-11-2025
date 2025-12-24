using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Formation_ECommerce_11_2025.Core.Entities.Products;




namespace Formation_ECommerce_11_2025.Core.Entities.Cart;

public class CartDetails
{
    [Required]
    [ForeignKey("CartHeader")]
	public Guid CartHeaderId { get; set; }

    [Required]
    [ForeignKey("Product")]
	public Guid ProductId { get; set; }

    public int Count { get; set; }

    public Product Product { get; set; }
	public CartHeader CartHeader { get; set; }


}

