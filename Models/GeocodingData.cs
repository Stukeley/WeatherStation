using System.Text.Json.Serialization;

namespace WeatherStation.Models;

public class GeocodingData
{
    [JsonPropertyName("lat")]
    public double Latitude { get; set; }
    
    [JsonPropertyName("lon")]
    public double Longitude { get; set; }
}