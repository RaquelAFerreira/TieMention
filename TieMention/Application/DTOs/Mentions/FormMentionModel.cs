namespace  TieMention.Application.DTOs;

using System.ComponentModel.DataAnnotations;

public class FormMentionModel
{
    [Required]
    public string? Image { get; set; }

    [Required]
    public Guid? MentionerPieceId { get; set; }

    [Required]
    public Guid? MentionedPieceId { get; set; }

    [MaxLength(1000)]
    public string? Description { get; set; }
}
