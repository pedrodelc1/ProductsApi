using ProductsApi.Entities;
using ProductsApi.Models.DTOs.Requests;
using ProductsApi.Models.DTOs.Responses;
using ProductsApi.Repositories.Interfaces;
using ProductsApi.Services.Interfaces;

namespace ProductsApi.Services.Implementations;

public class ProductService : IProductService
{
    private readonly IProductRepository _repository;

    public ProductService(IProductRepository repository)
    {
        _repository = repository;
    }

    public List<ProductForReadDto> GetAllProducts()
    {
        return _repository.GetAllProducts().Select(ToReadDto).ToList();
    }

    public ProductForReadDto? GetProductById(int id)
    {
        var product = _repository.GetProductById(id);
        return product is null ? null : ToReadDto(product);
    }

    public List<ProductForReadDto> SearchProductsByName(string name)
    {
        return _repository.SearchProductsByName(name).Select(ToReadDto).ToList();
    }

    public ProductStatsDto GetStats()
    {
        var products = _repository.GetAllProducts();

        if (products.Count == 0)
        {
            return new ProductStatsDto { Total = 0, AveragePrice = 0, MostExpensiveName = string.Empty };
        }

        return new ProductStatsDto
        {
            Total = products.Count(),
            AveragePrice = products.Average(p => p.Price),
            MostExpensiveName = products.OrderByDescending(p => p.Price).First().Name
        };
    }

    public ProductForReadDto CreateProduct(ProductForCreateDto dto)
    {
        if (NameExists(dto.Name))
        {
            throw new InvalidOperationException($"Ya existe un producto con el nombre '{dto.Name}'.");
        }

        var product = new Product
        {
            Name = dto.Name,
            Price = dto.Price
        };

        _repository.AddProduct(product);

        return ToReadDto(product);
    }

    public void UpdateProduct(int id, ProductForUpdateDto dto)
    {
        var product = new Product
        {
            Id = id,
            Name = dto.Name,
            Price = dto.Price
        };

        _repository.UpdateProduct(product);
    }

    public void DeleteProduct(int id)
    {
        var product = _repository.GetProductById(id);

        if (product is not null)
        {
            _repository.DeleteProduct(product);
        }
    }

    private bool NameExists(string name)
    {
        return _repository.GetAllProducts()
            .Any(p => string.Equals(p.Name, name, StringComparison.OrdinalIgnoreCase));
    }

    private static ProductForReadDto ToReadDto(Product product)
    {
        return new ProductForReadDto
        {
            Id = product.Id,
            Name = product.Name,
            Price = product.Price
        };
    }
}
