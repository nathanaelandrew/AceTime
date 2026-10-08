namespace BlazorApp1.Models;

public class Registration
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid EventId { get; set; }
    public Guid ProfileId { get; set; }
    public Guid? TeamId { get; set; } // Nullable for individual play
    public RSVPStatus Status { get; set; }
    public bool IsPaid { get; set; }
}