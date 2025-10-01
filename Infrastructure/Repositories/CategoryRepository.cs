using Application.RepositoryInterfaces;
using AutoMapper;
using Domain.Models;
using Infrastructure.AppDbContext;
using Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class CategoryRepository : ICategoryRepository
{
    private readonly CheezManagerDbContext _dbContext;
    private readonly IMapper _mapper;

    public CategoryRepository(CheezManagerDbContext dbContext, IMapper mapper)
    {
        _dbContext = dbContext;
        _mapper = mapper;
    }

    public async Task<Category?> GetCategoryAsync(Guid categoryId)
    {
        var category = await _dbContext.Categories.FindAsync(categoryId);
        if(category == null) return null;
        
        return _mapper.Map<Category>(category);
    }

    public async Task<List<Category>> GetCategoriesAsync(Guid userId)
    {
        var categories = await _dbContext.Categories.Where(c => c.UserId == userId).ToListAsync();
        return _mapper.Map<IEnumerable<Category>>(categories).ToList();
    }

    public async Task<bool> CreateCategoryAsync(Category category)
    {
        var categoryEntity = _mapper.Map<Category>(category);
        await _dbContext.AddAsync(categoryEntity);
        return await _dbContext.SaveChangesAsync() > 0;
    }

    public async Task<bool> UpdateCategoryAsync(Category category)
    {
        var categoryEntity = await _dbContext.Categories.FindAsync(category.Id);
        categoryEntity = _mapper.Map<CategoryEntity>(category);
        _dbContext.Categories.Update(categoryEntity);
        return await _dbContext.SaveChangesAsync() > 0;
    }

    public async Task<bool> DeleteCategoryAsync(Guid categoryId)
    {
        var categoryEntity = _dbContext.Categories.Find(categoryId);
        if (categoryEntity == null) return false;
        
        _dbContext.Categories.Remove(categoryEntity);
        return await _dbContext.SaveChangesAsync() > 0;
    }
}