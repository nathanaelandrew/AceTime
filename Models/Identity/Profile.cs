using BlazorApp1.Models.ClubVenue; 
using BlazorApp1.Models.Competition;

namespace BlazorApp1.Models.Identity;

public class Profile
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid AccountId { get; set; }
    public string Username { get; set; } = string.Empty;
    public string AvatarUrl { get; set; } = string.Empty;
    public string Bio { get; set; } = string.Empty;

    // Logic Helper
    public float CalculateWinRate() => 0.0f; // To be implemented

    // Navigation Properties
    public List<SkillRating> SkillRatings { get; set; } = new();
    public List<Notification> Notifications { get; set; } = new();
    public List<ClubMembership> ClubMemberships { get; set; } = new();
    public List<TeamMember> TeamMemberships { get; set; } = new();
}