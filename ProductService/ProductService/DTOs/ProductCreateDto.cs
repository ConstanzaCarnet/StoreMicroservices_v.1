using System.ComponentModel.DataAnnotations;
using ProductService.Models;

namespace ProductService.DTOs;

public class ProductCreateDto
{
    [Required]
    [MaxLength(150)]
    public string Name { get; set; }

    [Range(0.01, double.MaxValue)]
    public decimal Price { get; set; }

    [MaxLength(500)]
    public string Description { get; set; }

    [Range(0, int.MaxValue)]
    public int Stock { get; set; }

}