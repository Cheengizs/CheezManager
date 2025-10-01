using Application.RepositoryInterfaces;
using AutoMapper;
using Domain.Models;
using Infrastructure.AppDbContext;
using Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class GoalRepository : IGoalRepository
{
    private readonly CheezManagerDbContext _dbContext;
    private readonly IMapper _mapper;
    
    public GoalRepository(CheezManagerDbContext context, IMapper mapper)
    {
        _dbContext = context;
        _mapper = mapper;
    }
    
    public async Task<Goal?> FindGoalAsync(Guid goalId)
    {
        var goal = await _dbContext.Goals.FindAsync(goalId);
        if(goal == null) return null;
        return _mapper.Map<Goal>(goal);
    }

    public async Task<List<Goal>> GetAllGoalsAsync(Guid userId)
    {
        var goals = await _dbContext.Goals.Where(x => x.UserId == userId).ToListAsync();
        return _mapper.Map<IEnumerable<Goal>>(goals).ToList();
    }

    public async Task<bool> CreateGoalAsync(Goal goal)
    {
        var goalEntity = _mapper.Map<GoalEntity>(goal);
        await _dbContext.Goals.AddAsync(goalEntity);
        return await _dbContext.SaveChangesAsync() > 0;
    }

    public async Task<bool> DeleteGoalAsync(Guid goalId)
    {
        var goal = await _dbContext.Goals.FindAsync(goalId);
        if (goal == null) return false;
        _dbContext.Goals.Remove(goal);
        return await _dbContext.SaveChangesAsync() > 0;
    }

    public async Task<bool> UpdateGoalAsync(Goal goal)
    {
        var goalEntity = await _dbContext.Goals.FindAsync(goal.Id);
        _mapper.Map(goal, goalEntity);
        return await _dbContext.SaveChangesAsync() > 0;
    }
}