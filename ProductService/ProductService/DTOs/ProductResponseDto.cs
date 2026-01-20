using ProductService.Models;

namespace ProductService.DTOs;

public class ProductResponseDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string Description { get; set; }
    public int Stock { get; set; }

    public ProductResponseDto(Product product)
    {
        Id = product.Id;
        Name = product.Name;
        Price = product.Price;
        Description = product.Description;
        Stock = product.Stock;
    }
}
