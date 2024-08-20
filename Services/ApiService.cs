using FantasyPredictor.Web.Interfaces;

namespace FantasyPredictor.Web.Services;

public class ApiService : IApiService
{
    private readonly HttpClient _httpClient;

    public ApiService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<string> GetApiDataAsync(string requestUri)
    {
        var response = await _httpClient.GetAsync(requestUri);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }
}