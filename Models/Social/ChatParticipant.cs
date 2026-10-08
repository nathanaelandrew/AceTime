namespace BlazorApp1.Models;

public class ChatParticipant
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid ConversationId { get; set; }
    public Guid ProfileId { get; set; }
    public DateTime JoinedAt { get; set; } = DateTime.UtcNow;
}