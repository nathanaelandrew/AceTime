namespace BlazorApp1.Models;

public class Conversation
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Title { get; set; } = string.Empty;
    public bool IsGroup { get; set; }
    
    public List<ChatParticipant> Participants { get; set; } = new();
    public List<Message> Messages { get; set; } = new();
}

public class Message
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid ConversationId { get; set; }
    public Guid SenderId { get; set; } // ProfileId
    public string Content { get; set; } = string.Empty;
    public DateTime SentAt { get; set; } = DateTime.UtcNow;
}