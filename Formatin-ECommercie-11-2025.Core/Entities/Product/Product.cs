using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Formation_ECommerce_11_2025.Core.Common;
using Formation_ECommerce_11_2025.Core.Entities.Cart;
using Formation_ECommerce_11_2025.Core.Entities.Categories; // <-- MANQUANT

namespace Formation_ECommerce_11_2025.Core.Entities.Products;

public class Product : BaseEntity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }

    [Required]
    [Column(TypeName = "decimal(10, 2)")]
    public decimal price { get; set; }

    [Required]
    public Guid CategoryId { get; set; }

    public Category Category { get; set; }
    public ICollection<CartDetails> CartDetails { get; set; }
}
