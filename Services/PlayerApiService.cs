using FantasyPredictor.Web.Interfaces;
using FantasyPredictor.Web.Models;

namespace FantasyPredictor.Web.Services;

public class PlayerApiService : IApiService
{
    private readonly HttpClient _httpClient;
    private readonly string _apiKey;
    private readonly string _baseUrl;

    public PlayerApiService(HttpClient httpClient, IConfigurationService configuration)
    {
        _httpClient = httpClient;
        var playerApiConfig = configuration.GetSection<PlayerApiConfig>("PlayerApi");
        _apiKey = playerApiConfig.ApiKey;
        _baseUrl = playerApiConfig.BaseUrl;
    }

    public async Task<string> GetApiDataAsync(string requestUri)
    {
        var response = await _httpClient.GetAsync(requestUri);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }
}

