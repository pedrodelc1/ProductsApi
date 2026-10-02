namespace ProductsApi.Models.DTOs.Responses;

public class ProductForReadDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public decimal Price { get; set; }
}
