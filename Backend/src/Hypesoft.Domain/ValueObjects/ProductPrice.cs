namespace Hypesoft.Domain.ValueObjects;

public class ProductPrice
{
    public decimal Value { get; }

    public ProductPrice(decimal value)
    {
        if (value < 0)
            throw new ArgumentException("Price cannot be negative.");

        Value = value;
    }
}