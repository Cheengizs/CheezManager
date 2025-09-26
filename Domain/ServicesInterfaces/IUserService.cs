using Domain.Models;

namespace Domain.ServicesInterfaces;

public interface IUserService
{
    Task CreateUserAsync(User user);
    Task<User> FindUserAsync(Guid userId);
    Task UpdateUserAsync(User user);
    Task DeleteUserAsync(Guid userId);
}