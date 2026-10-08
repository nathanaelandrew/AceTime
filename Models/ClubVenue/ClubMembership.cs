namespace BlazorApp1.Models.ClubVenue;

public class ClubMembership
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid ClubId { get; set; }
    public Guid ProfileId { get; set; }
    public MembershipRole Role { get; set; }
    public DateTime JoinedAt { get; set; } = DateTime.Now;
}