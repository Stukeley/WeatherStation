using System.Text.Json.Serialization;

namespace WeatherStation.Models;

public class WindData
{
    [JsonPropertyName("speed")]
    public double Speed { get; set; }

    [JsonPropertyName("deg")]
    public int? Degree { get; set; }

    [JsonPropertyName("gust")]
    public double? Gust { get; set; }
}