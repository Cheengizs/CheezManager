using Application.RepositoryInterfaces;
using Domain.Models;
using Domain.ServicesInterfaces;

namespace Application.Services;

public class GoalService : IGoalService
{
    private readonly IGoalRepository _goalRepository;

    public async Task CreateGoalAsync(Goal goal)
    {
        await _goalRepository.CreateGoalAsync(goal);
    }
    
    public async Task<Goal> FindGoalAsync(Guid userId)
    {
        return await _goalRepository.FindGoalAsync(userId);
    }

    public async Task UpdateGoalAsync(Goal goal)
    {
        await _goalRepository.UpdateGoalAsync(goal);
    }

    public async Task DeleteGoalAsync(Guid goalId)
    {
        await _goalRepository.DeleteGoalAsync(goalId);
    }
}