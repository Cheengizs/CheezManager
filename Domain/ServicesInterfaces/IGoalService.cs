using Domain.Models;

namespace Domain.ServicesInterfaces;

public interface IGoalService
{
    Task CreateGoalAsync(Goal goal);
    Task<Goal> FindGoalAsync(Guid userId);
    Task UpdateGoalAsync(Goal goal);
    Task DeleteGoalAsync(Guid goalId);
}