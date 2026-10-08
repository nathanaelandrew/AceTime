namespace BlazorApp1.Models.Identity;

public class Account
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Email { get; set; } = string.Empty;
    public string PasswordHash { get; set; } = string.Empty;
    public UserRole Role { get; set; }
    public DateTime LastLogin { get; set; }
    
    // Navigation Property
    public Profile Profile { get; set; } = null!;
}