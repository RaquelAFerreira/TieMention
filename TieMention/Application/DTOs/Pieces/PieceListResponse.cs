namespace  TieMention.Application.DTOs;

public class PieceListResponse<T>
{
    public List<T> Items { get; set; } = new();

    public int TotalPages { get; set; }

    public int TotalItems { get; set; }

    public int PageSize { get; set; }

    public int Page { get; set; }
}