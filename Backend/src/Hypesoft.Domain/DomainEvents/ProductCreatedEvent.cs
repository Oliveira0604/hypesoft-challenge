namespace Hypesoft.Domain.DomainEvents;

public class ProductCreatedEvent : IDomainEvent
{
    public string ProductId { get; }
    public string Name { get; }
    public DateTime OccurredOn { get; }

    public ProductCreatedEvent(string productId, string name)
    {
        ProductId = productId;
        Name = name;
        OccurredOn = DateTime.UtcNow;
    }
}