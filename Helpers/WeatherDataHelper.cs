using System.Text.Json;
using WeatherStation.Models;

namespace WeatherStation.Helpers;

public static class WeatherDataHelper
{
    public static WeatherData DeserializeWeatherData(string json)
    {
        var weatherData = JsonSerializer.Deserialize<WeatherData>(json, new JsonSerializerOptions()
        {
            PropertyNameCaseInsensitive = true
        });

        return weatherData;
    }

    public static GeocodingData DeserializeGeoData(string json)
    {
        var geocodingData = JsonSerializer.Deserialize<GeocodingData[]>(json, new JsonSerializerOptions()
        {
            PropertyNameCaseInsensitive = true
        });
        
        return geocodingData.FirstOrDefault();
    }
}