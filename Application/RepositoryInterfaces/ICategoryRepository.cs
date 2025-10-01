using Domain.Models;

namespace Application.RepositoryInterfaces;

public interface ICategoryRepository
{
    Task<Category> GetCategoryAsync(Guid categoryId);
    Task<List<Category>> GetCategoriesAsync(Guid userId);
    Task<bool> CreateCategoryAsync(Category category);
    Task<bool> UpdateCategoryAsync(Category category);
    Task<bool> DeleteCategoryAsync(Guid categoryId);
}