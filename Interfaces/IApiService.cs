namespace FantasyPredictor.Web.Interfaces;

public interface IApiService
{
    Task<string> GetApiDataAsync(string requestUri);
    
}