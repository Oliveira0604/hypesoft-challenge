namespace Hypesoft.Domain.Entities;

public class Category
{
    public string Id { get; private set; } = Guid.NewGuid().ToString();

    public string Name { get; private set; } 

    public Category(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Category name cannot be empty.");

        if (name.Length < 3)
            throw new ArgumentException("Category name must be at least 3 characters long.");

        Name = name;
    }

    public void UpdateName(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Category name cannot be empty.");

        if (name.Length < 3)
            throw new ArgumentException("Category name must be at least 3 characters long.");

        Name = name;
    }
}