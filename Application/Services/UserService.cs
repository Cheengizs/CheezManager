using Application.RepositoryInterfaces;
using Domain.Models;
using Domain.ServicesInterfaces;

namespace Application.Services;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;
    
    public async Task CreateUserAsync(User user)
    {
        await _userRepository.CreateUserAsync(user);
    }

    public async Task DeleteUserAsync(Guid userId)
    {
        await _userRepository.DeleteUserAsync(userId);
    }

    public async Task<User> FindUserAsync(Guid userId)
    {
        return await _userRepository.GetUserAsync(userId);
    }

    public async Task UpdateUserAsync(User user)
    {
        await _userRepository.UpdateUserAsync(user);
    }
}