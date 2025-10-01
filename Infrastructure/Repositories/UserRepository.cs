using Application.RepositoryInterfaces;
using Domain.Models;
using Infrastructure.AppDbContext;
using Infrastructure.Entities;

namespace Infrastructure.Repositories;

public class UserRepository : IUserRepository
{
    private readonly CheezManagerDbContext _dbContext;

    public UserRepository(CheezManagerDbContext context)
    {
        _dbContext = context;
    }

    public async Task<bool> CreateUserAsync(User user)
    {
        UserEntity userEntity = new()
        {
            Id = user.Id,
            Email = user.Email,
            Username = user.Username,
            CreatedDate = DateTime.UtcNow,
            PasswordHash = user.PasswordHash,
        };

        await _dbContext.Users.AddAsync(userEntity);
        return await _dbContext.SaveChangesAsync() > 0;
    }

    public async Task<User> GetUserAsync(Guid userId)
    {
        UserEntity? userEntity = await _dbContext.Users.FindAsync(userId);
        if (userEntity == null) return null;

        return new User()
        {
            Id = userEntity.Id,
            Email = userEntity.Email,
            Username = userEntity.Username,
            PasswordHash = userEntity.PasswordHash,
            CreatedDate = userEntity.CreatedDate,
        };
    }

    public async Task<bool> UpdateUserAsync(User user)
    {
        var userEntity = await _dbContext.Users.FindAsync(user.Id);
        if (userEntity == null) return false;

        userEntity.Email = user.Email;
        userEntity.Username = user.Username;
        userEntity.PasswordHash = user.PasswordHash;
        userEntity.CreatedDate = DateTime.UtcNow;
        _dbContext.Users.Update(userEntity);
        return await _dbContext.SaveChangesAsync() > 0;
    }

    public async Task<bool> DeleteUserAsync(Guid userId)
    {
        var userEntity = await _dbContext.Users.FindAsync(userId);
        if (userEntity == null) return false;

        _dbContext.Users.Remove(userEntity);
        return await _dbContext.SaveChangesAsync() > 0;
    }
}