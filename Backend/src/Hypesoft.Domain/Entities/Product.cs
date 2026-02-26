namespace Hypesoft.Domain.Entities;

using Hypesoft.Domain.ValueObjects;
public class Product
{
    public string Id { get; private set; } = Guid.NewGuid().ToString();

    public ProductName Name { get; private set; }
    public ProductDescription Description { get; private set; }
    public ProductPrice Price { get; private set; }
    public ProductCategoryId CategoryId { get; private set; }
    public ProductQuantity StockQuantity { get; private set; }

    public Product(
        string name,
        string description,
        decimal price,
        string categoryId,
        int stockQuantity
    )

    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Product name cannot be empty.");

        if (string.IsNullOrWhiteSpace(description))
            throw new ArgumentException("Product description cannot be empty.");

        if (price < 0)
            throw new ArgumentException("Price cannot be negative.");

        if (stockQuantity < 0)
            throw new ArgumentException("Stock quantity cannot be negative.");

        if (string.IsNullOrWhiteSpace(categoryId))
            throw new ArgumentException("Category ID cannot be empty.");

        Name = name;
        Description = description;
        Price = price;
        CategoryId = categoryId;
        StockQuantity = stockQuantity;
    }

    public void UpdateName(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Product name cannot be empty.");

        Name = name;
    }

    public void UpdateDescription(string description)
    {
        if (string.IsNullOrWhiteSpace(description))
            throw new ArgumentException("Product description cannot be empty.");

        Description = description;
    }

    public void UpdatePrice(decimal price)
    {
        if (price < 0)
            throw new ArgumentException("Price cannot be negative.");

        Price = price;
    }

    public void UpdateStock(int quantity)
    {
        if (quantity < 0)
            throw new ArgumentException("Quantity cannot be negative.");
        StockQuantity += quantity;
    }
}
