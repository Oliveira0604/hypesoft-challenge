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
        ProductName name,
        ProductDescription description,
        ProductPrice price,
        ProductCategoryId categoryId,
        ProductQuantity stockQuantity
    )

    {
        Name = name;
        Description = description;
        Price = price;
        CategoryId = categoryId;
        StockQuantity = stockQuantity;
    }

    public void UpdateName(string name)
    {
        Name = new ProductName(name);
    }

    public void UpdateDescription(string description)
    {
        Description = new ProductDescription(description);
    }

    public void UpdatePrice(decimal price)
    {
        Price = new ProductPrice(price);
    }

    public void UpdateStock(int quantity)
    {
        StockQuantity = new ProductQuantity(StockQuantity.Value + quantity);
    }
}
