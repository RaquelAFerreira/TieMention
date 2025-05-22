using TieMention.Models;
using System.Net.Http.Json;

namespace TieMention.Services;

public class PieceService
{
    private readonly HttpClient _http;

    public PieceService(HttpClient http)
    {
        _http = http;
    }

    public event Action? ApiResponse;

    public PieceListDto PieceDetails { get; set; }

    public void GetCurrentPieceDetails(PieceListDto pieceDetails)
    {

        PieceDetails = pieceDetails;
        ApiResponse?.Invoke();
    }

    public async Task<PieceListResponse<PieceListDto>?> GetPiecesAsync(string name, int page, int pageSize)
    {
        var url = $"http://localhost:5105/api/piece/list?Name={name}&Page={page}&PageSize={pageSize}";
        var request = new HttpRequestMessage(HttpMethod.Get, url);
        var response = await _http.SendAsync(request);

        if (response.IsSuccessStatusCode)
        {
            return await response.Content.ReadFromJsonAsync<PieceListResponse<PieceListDto>>();
        }

        return null;
    }

    public async Task<PieceListDto?> GetPieceAsync(Guid Id)
    {
        var url = $"http://localhost:5105/api/piece/{Id}";
        var request = new HttpRequestMessage(HttpMethod.Get, url);
        var response = await _http.SendAsync(request);


        if (response.IsSuccessStatusCode)
        {
            return await response.Content.ReadFromJsonAsync<PieceListDto>();
        }
        return null;
    }
}
