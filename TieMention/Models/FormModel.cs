namespace TieMention.Models;

using System.ComponentModel.DataAnnotations;

public class FormModel
{
    [Required]
    public string? Image { get; set; }

    [Required, MaxLength(100)]
    public string? Name { get; set; }

    [Required]
    public string? Category { get; set; }

    [Range(1900, 2100)]
    public string? ReleaseYear { get; set; }

    [MaxLength(1000)]
    public string? Description { get; set; }
}
