namespace  TieMention.Application.DTOs;

using System.ComponentModel.DataAnnotations;

public class FormMentionModel
{
    [Required]
    public string? Image { get; set; }

    [Required, MaxLength(100)]
    public string? Name { get; set; }

    [Required]
    public string? MentionerPiece { get; set; }

    [MaxLength(1000)]
    public string? Description { get; set; }
}
