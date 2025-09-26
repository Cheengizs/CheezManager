using Domain.Models;

namespace Application.RepositoryInterfaces;

public interface ICategoryRepository
{
    Task<Category> GetCategoryAsync(Guid categoryId);
    Task<List<Category>> GetCategoriesAsync(Guid userId);
    Task CreateCategoryAsync(Category category);
    Task UpdateCategoryAsync(Category category);
    Task DeleteCategoryAsync(Guid categoryId);
}