using Domain.Models;

namespace Application.RepositoryInterfaces;

public interface IGoalRepository
{
    Task<Goal> FindGoalAsync(Guid goalId);
    Task<List<Goal>> GetAllGoalsAsync(Guid userId);
    Task CreateGoalAsync(Goal goal);
    Task DeleteGoalAsync(Guid goalId);
    Task UpdateGoalAsync(Goal goal);
}