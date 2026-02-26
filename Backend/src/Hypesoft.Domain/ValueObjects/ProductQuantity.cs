namespace Hypesoft.Domain.ValueObjects;

public class ProductQuantity
{
    public int Value { get; }

    public ProductQuantity(int value)
    {
        if (value < 0)
            throw new ArgumentException("Quantity cannot be negative.");

        Value = value;
    }
}