using Domain.Models;

namespace Application.RepositoryInterfaces;

public interface IUserRepository
{
    Task CreateUserAsync(User user);
    Task<User> GetUserAsync(Guid userId);
    Task UpdateUserAsync(User user);
    Task DeleteUserAsync(Guid userId);
}