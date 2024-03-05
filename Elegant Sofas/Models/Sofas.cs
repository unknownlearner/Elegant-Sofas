using System.ComponentModel.DataAnnotations;

namespace Elegant_Sofas.Models;

public class Sofas
{
    public int Id { get; set; }
    public string? Product { get; set; }
    public string? Color { get; set; }
    public string? Material { get; set; }
    public decimal Price { get; set; }
    public string? Rating { get; set; }
}