using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Formatin_ECommercie_11_2025.Core.Interfaces.Repositories.Base
{
	public interface IRepository<TEntity> where TEntity: class
	{
		Task<TEntity> GetByIdAsync(Guid id);
		Task<TEntity> AddAsync(TEntity entity);
		Task<IEnumerable<TEntity>> GetAllAsync();
		Task Update(TEntity entity);
		Task Remove(TEntity entity);
		// Sauvegarde les changements et retourne le nombre d'enregistrements affectés
		Task<int> SaveChangesAsync();
	}
}

