namespace BlazorApp1.Models.ClubVenue;

public class AvailabilitySlot
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid CourtId { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public bool IsBooked { get; set; }
}