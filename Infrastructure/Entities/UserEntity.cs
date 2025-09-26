using Domain.Models;

namespace Infrastructure.Entities;

public class UserEntity
{
    public Guid Id { get; set; }
    public string Username { get; set; }
    public string PasswordHash { get; set; }
    public DateTime CreatedDate { get; set; }
    public string? Email { get; set; }
    
    public List<GoalEntity> Goals { get; set; }
    public List<CategoryEntity> Categories { get; set; }
}