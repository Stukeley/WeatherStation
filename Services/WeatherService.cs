using System.Net.Http;
using System.Text.Json;
using WeatherStation.Helpers;
using WeatherStation.Models;

namespace WeatherStation.Services;

public static class WeatherService
{
    private static readonly HttpClient _httpClient = new HttpClient();
    
    public static async Task<WeatherData> GetWeatherDataAsync(double latitude, double longitude)
    {
        var apiKey = ApiKeyHelper.ApiKey;
        var url = $"https://api.openweathermap.org/data/2.5/weather?lat={latitude}&lon={longitude}&units=metric&appid={apiKey}";

        var response = await _httpClient.GetAsync(url);
        
        var json = await response.Content.ReadAsStringAsync();
        
        return WeatherDataHelper.DeserializeWeatherData(json);
    }

    public static async Task<WeatherData> GetWeatherDataAsync(string city, string country)
    {
        var geocodingData = await GetLatitudeAndLongitudeAsync(city, country);
        
        return await GetWeatherDataAsync(geocodingData.Latitude, geocodingData.Longitude);
    }
    
    private static async Task<GeocodingData> GetLatitudeAndLongitudeAsync(string city, string country)
    {
        var apiKey = ApiKeyHelper.ApiKey;
        var url = $"http://api.openweathermap.org/geo/1.0/direct?q={city},{country}&limit={1}&appid={apiKey}";

        var response = await _httpClient.GetAsync(url);
        
        var json = await response.Content.ReadAsStringAsync();
        
        return WeatherDataHelper.DeserializeGeoData(json);
    }
}