using Application.RepositoryInterfaces;
using Domain.Models;
using Domain.ServicesInterfaces;

namespace Application.Services;

public class CategoryService : ICategoryService
{
    private readonly ICategoryRepository _categoryRepository;
    
    public async Task CreateCategory(Category category)
    {
        await _categoryRepository.CreateCategoryAsync(category);
    }

    public async Task<Category> FindCategoryAsync(Guid categoryId)
    {
        return await _categoryRepository.GetCategoryAsync(categoryId);
    }

    public async Task UpdateCategoryAsync(Category category)
    {
        await _categoryRepository.UpdateCategoryAsync(category);
    }

    public async Task DeleteCategory(Guid categoryId)
    {
        await _categoryRepository.DeleteCategoryAsync(categoryId);
    }
}