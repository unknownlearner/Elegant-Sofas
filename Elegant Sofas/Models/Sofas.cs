using System.ComponentModel.DataAnnotations;

namespace Elegant_Sofas.Models;

public class Sofas
{
    public int Id { get; set; }
    [StringLength(60, MinimumLength = 3)]
    [Required]
    public string? Product { get; set; }
    [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
    [Required]
    [StringLength(30)]
    public string? Color { get; set; }
    [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
    [Required]
    [StringLength(30)]
    public string? Material { get; set; }
    [Range(1, 2000)]
    [DataType(DataType.Currency)]
    public decimal Price { get; set; }
    [Range(1.0, 5.0)]
    [Required]
    public string? Rating { get; set; }
}