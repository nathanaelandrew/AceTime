namespace BlazorApp1.Models;

public class Event
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid ClubId { get; set; }
    public Guid VenueId { get; set; }
    public string Title { get; set; } = string.Empty;
    public EventType Type { get; set; }
    public decimal EntryFee { get; set; }
    public int Capacity { get; set; }

    public List<Registration> Registrations { get; set; } = new();
    public List<Match> Matches { get; set; } = new();
}