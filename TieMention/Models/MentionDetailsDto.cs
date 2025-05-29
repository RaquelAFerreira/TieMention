namespace TieMention.Models;

public class MentionDetailsDto
{
    public Guid IdMention { get; set; }

    public Guid IdPiece { get; set; }

    public string MentionImage { get; set; } = default!;

    public string MentionDescription { get; set; } = default!;

    public string MentionerName { get; set; } = default!;

    public string MentionedName { get; set; } = default!;

    public string MentionerCategory { get; set; } = default!;

    public string MentionedCategory { get; set; } = default!;

    public string MentionerSlug { get; set; } = default!;

    public string MentionedSlug { get; set; } = default!;

    public string MentionerReleaseYear { get; set; } = default!;

    public string MentionedReleaseYear { get; set; } = default!;
}