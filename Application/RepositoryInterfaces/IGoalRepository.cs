using Domain.Models;

namespace Application.RepositoryInterfaces;

public interface IGoalRepository
{
    Task<Goal?> FindGoalAsync(Guid goalId);
    Task<List<Goal>> GetAllGoalsAsync(Guid userId);
    Task<bool> CreateGoalAsync(Goal goal);
    Task<bool> DeleteGoalAsync(Guid goalId);
    Task<bool> UpdateGoalAsync(Goal goal);
}