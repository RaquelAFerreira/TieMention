using  TieMention.Application.DTOs;
using System.Net.Http.Json;

namespace TieMention.Services;

public class MentionService
{
    private readonly HttpClient _http;

    public MentionService(HttpClient http)
    {
        _http = http;
    }

    public async Task<MentionDetailsDto?> GetMentionAsync(Guid id, string Slug = null)
    {

        var url = $"http://localhost:5105/api/mention/{Slug}";

        var request = new HttpRequestMessage(HttpMethod.Get, url);
        var response = await _http.SendAsync(request);

        if (response.IsSuccessStatusCode)
        {
            return await response.Content.ReadFromJsonAsync<MentionDetailsDto>();
        }
        return null;
    }

    public async Task<List<PieceComboboxDto?>> GetMentionByNameAsync(string Name)
    {

        var url = $"http://localhost:5105/api/mention/{Name}";

        var request = new HttpRequestMessage(HttpMethod.Get, url);
        var response = await _http.SendAsync(request);

        if (response.IsSuccessStatusCode)
        {
            return await response.Content.ReadFromJsonAsync<List<PieceComboboxDto?>>();
        }
        return null;
    }
}
