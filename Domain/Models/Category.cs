namespace Domain.Models;

public class Category
{
    public Guid Id { get; private set; }
    public string ShortName { get; private set; }
    public string Description { get; private set; }
    public User User { get; private set; }
}