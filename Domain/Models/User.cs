namespace Domain.Models;

public class User
{
    public Guid Id { get; private set; }
    public string Username { get; private set; }
    public string PasswordHash { get; private set; }
    public DateTime CreatedDate { get; private set; }
    public string? Email { get; private set; }
}