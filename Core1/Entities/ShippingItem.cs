
using System.ComponentModel.DataAnnotations;

namespace Core1.Entities;

public class ShippingItem
{
    public int Id { get; set; }
    [Required]
    public string? Image { get; set; }
    [Required,MaxLength(100)]
    public string? Title { get; set; }
    public string? Description { get; set; }
}
