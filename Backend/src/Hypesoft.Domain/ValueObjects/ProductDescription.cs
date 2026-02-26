namespace Hypesoft.Domain.ValueObjects;

public class ProductDescription
{
    public string Value { get; }

    public ProductDescription(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new ArgumentException("Description cannot be empty.");
        
        var trimmedValue = value.Trim();

        if (trimmedValue.Length < 10 || trimmedValue.Length > 1000)
            throw new ArgumentException("Description must be between 10 and 1000 characters long.");

        Value = trimmedValue;
    }
}