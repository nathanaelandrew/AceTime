namespace BlazorApp1.Models.Identity;

public class SkillRating
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid ProfileId { get; set; }
    public string SportName { get; set; } = string.Empty;
    public float Value { get; set; }
    public string Provider { get; set; } = "Internal";
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
}