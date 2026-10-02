using ProductsApi.Models.DTOs.Requests;
using ProductsApi.Models.DTOs.Responses;

namespace ProductsApi.Services.Interfaces;

public interface IProductService
{
    List<ProductForReadDto> GetAllProducts();
    ProductForReadDto? GetProductById(int id);
    List<ProductForReadDto> SearchProductsByName(string name);
    ProductStatsDto GetStats();
    ProductForReadDto CreateProduct(ProductForCreateDto dto);
    void UpdateProduct(int id, ProductForUpdateDto dto);
    void DeleteProduct(int id);
}
