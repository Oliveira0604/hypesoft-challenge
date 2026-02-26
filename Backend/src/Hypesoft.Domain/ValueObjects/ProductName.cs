namespace Hypesoft.Domain.ValueObjects;

using System.Text.RegularExpressions;

public partial class ProductName
{
    public string Value { get; }
    [GeneratedRegex(@"^[a-zA-Z0-9\s]+$")]
    private static partial Regex NameRegex();

    public ProductName(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new ArgumentException("Name cannot be empty.");

        var trimmedValue = value.Trim();
        
        if (trimmedValue.Length < 3 || trimmedValue.Length > 100)
            throw new ArgumentException("Name must be between 3 and 100 characters long.");
        
        
        if (!NameRegex().IsMatch(trimmedValue))
            throw new ArgumentException("Name can only contain letters, numbers, and spaces.");

        Value = trimmedValue;
    }
}