namespace BlazorApp1.Models.ClubVenue;

public class Club
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; } = string.Empty;
    public string Slug { get; set; } = string.Empty;
    public bool IsVerified { get; set; }
    public string BannerUrl { get; set; } = string.Empty;

    public List<ClubMembership> Members { get; set; } = new();
    public List<Event> Events { get; set; } = new();
}