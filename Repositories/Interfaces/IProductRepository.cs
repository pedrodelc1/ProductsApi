using ProductsApi.Entities;

namespace ProductsApi.Repositories.Interfaces;

public interface IProductRepository
{
    List<Product> GetAllProducts();
    Product? GetProductById(int id);
    List<Product> SearchProductsByName(string name);
    void AddProduct(Product product);
    void UpdateProduct(Product product);
    void DeleteProduct(Product product);
}
