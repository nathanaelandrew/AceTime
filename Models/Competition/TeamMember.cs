namespace BlazorApp1.Models.Competition;

public class TeamMember
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid TeamId { get; set; }
    public Guid ProfileId { get; set; }
}