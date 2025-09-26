namespace Infrastructure.Entities;

public class GoalEntity
{
    public Guid Id { get; set; }
    public string ShortName { get; set; }
    public string Description { get;  set; }
    public DateTime CreatedDate { get;  set; }
    public DateTime EstimatedEndDate { get;  set; }
    public DateTime EndDate { get;  set; }
    public int Amount { get;  set; }
    public bool IsCompleted { get;  set; }
    
    public CategoryEntity Category { get;  set; }
    public UserEntity User { get;  set; }
    
}