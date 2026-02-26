namespace Hypesoft.Domain.ValueObjects;

using System.Text.RegularExpressions;
public partial class ProductCategoryId
{
    public string Value { get; }

    [GeneratedRegex(@"^[0-9a-fA-F]{24}$")]
    private static partial Regex ObjectIdRegex();

    public ProductCategoryId(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new ArgumentException("Category cannot be empty.");

        var trimmedValue = value.Trim();

        if (!ObjectIdRegex().IsMatch(trimmedValue))
            throw new ArgumentException("Category must be a valid ObjectId (24 hex characters).");

        Value = trimmedValue;
    }
}