using Domain.Models;

namespace Domain.ServicesInterfaces;

public interface ICategoryService
{
    Task CreateCategory(Category category);
    Task<Category> FindCategoryAsync(Guid categoryId);
    Task UpdateCategoryAsync(Category category);
    Task DeleteCategory(Guid categoryId);
}