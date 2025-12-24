using System;
using Formatin_ECommercie_11_2025.Core.Interfaces.Repositories.Base;
using Formation_ECommerce_11_2025.Core.Entities.Categories;

namespace Formation_Ecommerce_11_2025.Core.Interfaces.Repositories
{
    // Interface qui définit les opérations spécifiques pour les catégories, hérite de l'interface générique IRepository
    public interface ICategoryRepository : IRepository<Category>
    {
        // Ajoute une nouvelle catégorie à la base de données
        Task<Category> AddAsync(Category category);

        // Récupère une catégorie par son identifiant
        Task<Category> ReadByIdAsync(Guid categoryId);

        // Récupère toutes les catégories existantes
        Task<IEnumerable<Category>> ReadAllAsync();

        // Trouve l'identifiant d'une catégorie à partir de son nom
        Task<Guid?> GetCategoryIdByCategoryNameAsync(string categoryName);

        // Met à jour une catégorie existante
        Task Update(Category category);

        // Supprime une catégorie par son identifiant
        Task DeleteAsync(Guid categoryId);
    }
}
