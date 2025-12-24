using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Formatin_ECommercie_11_2025.Core.Interfaces.Repositories.Base;
using Formation_ECommerce_11_2025.Core.Entities.Products;
namespace Formatin_ECommercie_11_2025.Core.Interfaces.Repositories
{
	public interface IProductRepository : IRepository<Formation_ECommerce_11_2025.Core.Entities.Products.Product>
	{
		Task<Product> AddAsync(Product product);
		Task<Product> ReadByIdAsync(Guid porductId);
		Task<IEnumerable<Product>> ReadAllAsync();
		Task UpdateAsync(Product product);
		Task DeleteAsync(Guid productId);
		Task<IEnumerable<Product>> GetProductsByCategoryId(Guid categoryId);
	}
}

