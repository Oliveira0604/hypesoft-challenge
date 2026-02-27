namespace Hypesoft.Application.DTOs.Product;

public record ProductResponse
{
    public string Id { get; init; }
    public string Name { get; init; }
    public string Description { get; init; }
    public decimal Price { get; init; }
    public string CategoryId { get; init;}
    public string CategoryName { get; init; }
    public int StockQuantity { get; init; }

    public bool IsLowStock => StockQuantity < 10;

    public ProductResponse(string id, string name, string description, decimal price, string categoryId, string categoryName, int stockQuantity)
    {
        Id = id;
        Name = name;
        Description = description;
        Price = price;
        CategoryId = categoryId;
        CategoryName = categoryName;
        StockQuantity = stockQuantity;
    }
}