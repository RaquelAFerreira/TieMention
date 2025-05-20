namespace TieMention.Models;

public class PieceDto
{
    public Guid Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Slug { get; set; } = string.Empty;

    public string Image { get; set; } = string.Empty;

    public string ReleaseYear { get; set; } = string.Empty;
}