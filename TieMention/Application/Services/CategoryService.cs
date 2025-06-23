using  TieMention.Application.DTOs;
using System.Net.Http.Json;

namespace TieMention.Services;

public class CategoryService
{
    private readonly HttpClient _http;

    public CategoryService(HttpClient http)
    {
        _http = http;
    }

    public async Task<List<CategoryDto?>> GetCategoriesAsync()
    {

        var url = $"http://localhost:5105/api/category";

        var request = new HttpRequestMessage(HttpMethod.Get, url);
        var response = await _http.SendAsync(request);

        if (response.IsSuccessStatusCode)
        {
            return await response.Content.ReadFromJsonAsync<List<CategoryDto>>();
        }
        return null;
    }
}
