namespace  TieMention.Application.DTOs;

public class MentionDetailsDto
{
    public Guid Id { get; set; }

    public string Image { get; set; } = default!;

    public string Description { get; set; } = default!;

    public PieceListDto MentionerPiece { get; set; } = default!;

    public PieceListDto MentionedPiece { get; set; } = default!;
}