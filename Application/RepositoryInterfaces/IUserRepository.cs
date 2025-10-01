using Domain.Models;

namespace Application.RepositoryInterfaces;

public interface IUserRepository
{
    Task<bool> CreateUserAsync(User user);
    Task<User> GetUserAsync(Guid userId);
    Task<bool> UpdateUserAsync(User user);
    Task<bool> DeleteUserAsync(Guid userId);
}