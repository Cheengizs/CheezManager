namespace Domain.Models;

public class Goal
{
    public Guid Id { get; private set; }
    public string ShortName { get; private set; }
    public string Description { get; private set; }
    public DateTime CreatedDate { get; private set; }
    public DateTime EstimatedEndDate { get; private set; }
    public DateTime EndDate { get; private set; }
    public int Amount { get; private set; }
    public bool IsCompleted { get; private set; }
    public Category Category { get; private set; }
    public User User { get; private set; }
    
    public void Complete()
    {
        IsCompleted = true;
        EndDate = DateTime.UtcNow;
    }
}