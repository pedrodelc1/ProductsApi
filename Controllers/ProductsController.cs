using Microsoft.AspNetCore.Mvc;
using ProductsApi.Models.DTOs.Requests;
using ProductsApi.Services.Interfaces;

namespace ProductsApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    private readonly IProductService _service;

    public ProductsController(IProductService service)
    {
        _service = service;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(_service.GetAllProducts());
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var product = _service.GetProductById(id);

        if (product is null)
        {
            return NotFound();
        }

        return Ok(product);
    }

    [HttpGet("search")]
    public IActionResult Search([FromQuery] string name)
    {
        return Ok(_service.SearchProductsByName(name));
    }

    [HttpGet("stats")]
    public IActionResult GetStats()
    {
        return Ok(_service.GetStats());
    }

    [HttpPost]
    public IActionResult Create(ProductForCreateDto dto)
    {
        try
        {
            var created = _service.CreateProduct(dto);
            return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
        }
        catch (InvalidOperationException ex)
        {
            return Conflict(ex.Message);
        }
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, ProductForUpdateDto dto)
    {
        if (_service.GetProductById(id) is null)
        {
            return NotFound();
        }

        _service.UpdateProduct(id, dto);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        if (_service.GetProductById(id) is null)
        {
            return NotFound();
        }

        _service.DeleteProduct(id);
        return NoContent();
    }
}
