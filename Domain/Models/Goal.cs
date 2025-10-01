namespace Domain.Models;

public class Goal
{
    public Guid Id { get; set; }
    public string ShortName { get; set; }
    public string Description { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime EstimatedEndDate { get; set; }
    public DateTime EndDate { get; set; }
    public int Amount { get; set; }
    public bool IsCompleted { get; set; }
    public Category Category { get; set; }
    public User User { get; set; }
    
    public void Complete()
    {
        IsCompleted = true;
        EndDate = DateTime.UtcNow;
    }
}