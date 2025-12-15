using System;
using System.ComponentModel.DataAnnotations;
using Formation_ECommerce_11_2025.Core.Common;
using Formation_ECommerce_11_2025.Core.Entities.Products;


namespace Formation_ECommerce_11_2025.Core.Entities.Categories;

public class Category
{
	[Required]
	[MaxLength(100, ErrorMessage= "Tis Category name cannot exeed 100 Charaters .")]
	public string name { get; set; }

	[MaxLength(100, ErrorMessage ="Category Description cannot exeed 100 Characters.")]
	public string Description { get; set; }

    public ICollection<Product> Product { get; set; }
}

