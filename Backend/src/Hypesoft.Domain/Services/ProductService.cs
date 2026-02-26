using Hypesoft.Domain.Repositories;

namespace Hypesoft.Domain.Services;

public class ProductService
{
    private readonly IProductRepository _repository;
    
    public ProductService(IProductRepository repository)
    {
        _repository = repository;
    }

    public async Task<bool> CanRegisterProduct(string name)
    {
        var existingProduct = await _repository.SearchByNameAsync(name);
        return existingProduct == null;
    }
}