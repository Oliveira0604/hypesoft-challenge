namespace Hypesoft.Domain.ValueObjects;

using System.Text.RegularExpressions;

public partial class CategoryName
{
    public string Value { get; }
    [GeneratedRegex(@"^[a-zA-Z0-9\s]+$")]
    private static partial Regex NameRegex();
    public CategoryName(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new ArgumentException("Category name cannot be empty.");

        var trimmedValue = value.Trim();

        if (trimmedValue.Length < 3 || trimmedValue.Length > 50)
            throw new ArgumentException("Category name must be between 3 and 50 characters long.");
        
        if (!NameRegex().IsMatch(trimmedValue))
            throw new ArgumentException("Category name can only contain letters, numbers, and spaces.");

        Value = trimmedValue;
    }
}