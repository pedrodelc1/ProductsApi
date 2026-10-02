using System.ComponentModel.DataAnnotations;

namespace ProductsApi.Models.DTOs.Requests;

public class ProductForCreateDto
{
    [Required(ErrorMessage = "El nombre es obligatorio.")]
    [StringLength(100, MinimumLength = 3, ErrorMessage = "El nombre debe tener entre 3 y 100 caracteres.")]
    public string Name { get; set; } = string.Empty;

    [Range(0, double.MaxValue, MinimumIsExclusive = true, ErrorMessage = "El precio debe ser mayor que cero.")]
    public decimal Price { get; set; }
}
