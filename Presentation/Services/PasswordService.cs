using Microsoft.AspNetCore.Identity;

namespace Presentation.Services;

public class PasswordService : IPasswordService
{
    private readonly PasswordHasher<object> _passwordHasher;

    public PasswordService()
    {
        
    }

    public string HashPassword(string password)
    {
        return _passwordHasher.HashPassword(null!, password);
    }

    public bool VerifyPassword(string password, string hashedPassword)
    {
        var res = _passwordHasher.VerifyHashedPassword(null!, hashedPassword, password);
        return res == PasswordVerificationResult.Success;
    }
    
}