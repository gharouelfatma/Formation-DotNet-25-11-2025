using System;
using Formation_Ecommerce_11_2025.Core.Entities.Orders;
using Formation_ECommerce_11_2025.Core.Entities.Cart;
using Formation_ECommerce_11_2025.Core.Entities.Categories;
using Formation_ECommerce_11_2025.Core.Entities.Coupons;
using Formation_ECommerce_11_2025.Core.Entities.Products;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Formation_ECommerce_11_025.Infrastructure.Persistance

{
	public class ApplicationDBContext : IdentityDbContext
	{
		public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options): base(options)
		{
		}
		public DbSet<Category> Categories { get; set; }

		public DbSet<Product> Products { get; set; }

		public DbSet<CartHeader> CartHeaders { get; set; }

		public DbSet<CartDetails> CartDetails { get; set; }

		public DbSet<OrderHeader> OrderHeaders{ get; set; }

		public DbSet<OrderDetails> OrderDetails { get; set; }

		public DbSet<Coupon> Coupons{ get; set; }






	}
}






