namespace BlazorApp1.Models;

public class Match
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid EventId { get; set; }
    public Guid CourtId { get; set; }
    public Guid Team1Id { get; set; }
    public Guid Team2Id { get; set; }
    public int RoundNumber { get; set; }
    public MatchStatus Status { get; set; }

    public List<Score> Scores { get; set; } = new();
}

public class Score
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid MatchId { get; set; }
    public int SetNumber { get; set; }
    public int Team1Points { get; set; }
    public int Team2Points { get; set; }
    public Guid WinnerId { get; set; }
}