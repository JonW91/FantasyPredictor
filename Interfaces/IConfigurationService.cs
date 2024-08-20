namespace FantasyPredictor.Web.Interfaces;

public interface IConfigurationService
{
    T GetSection<T>(string sectionName) where T : new();
}