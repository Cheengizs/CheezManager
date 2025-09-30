namespace Infrastructure.Entities;

public class CategoryEntity
{
    public Guid Id { get; private set; }
    public string ShortName { get; private set; }
    public string Description { get; private set; }
    
    public Guid? UserId { get; set; }
    public UserEntity User { get; private set; }
    public List<GoalEntity> Goals { get; private set; }
}