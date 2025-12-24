using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Formatin_ECommercie_11_2025.Core.Interfaces.Repositories.Base;
using Formation_ECommerce_11_025.Infrastructure.Persistance;
using Microsoft.EntityFrameworkCore;

namespace Formation_Ecommerce_11_2025.Core.Interfaces.Repositories.Base
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly ApplicationDBContext _context;
        protected readonly DbSet<TEntity> _entities;

        public Repository(ApplicationDBContext context)
        {
            _context = context;
            _entities = context.Set<TEntity>();
        }

        public async Task<TEntity> AddAsync(TEntity entity)
        {
            await _entities.AddAsync(entity);
            return entity;
        }
        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _entities.ToListAsync();
        }
        public async Task<TEntity> GetByIdAsync(Guid id)
        {
            return await _entities.FindAsync(id);
        }

        public Task Remove(TEntity entity)
        {
            _entities.Remove(entity);
            return Task.CompletedTask;
        }
        public Task Update(TEntity entity)
        {
            _entities.Update(entity);
            return Task.CompletedTask;
        }
        public Task<int> SaveChangesAsync()
        {
            return _context.SaveChangesAsync();
        }

    }
}