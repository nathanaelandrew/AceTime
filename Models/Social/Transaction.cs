namespace BlazorApp1.Models;

public class Transaction
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid ProfileId { get; set; }
    public Guid ReferenceId { get; set; }
    public decimal Amount { get; set; }
    public string Gateway { get; set; } = "GCash";
    public TransactionStatus Status { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}