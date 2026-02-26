namespace Hypesoft.Domain.DomainEvents;

public class LowStockEvent : IDomainEvent
{
    public string ProductId { get; }
    public int CurrentStock { get; }
    public DateTime OccurredOn { get; }

    public LowStockEvent(string productId, int currentStock)
    {
        ProductId = productId;
        CurrentStock = currentStock;
        OccurredOn = DateTime.UtcNow;
    }
}