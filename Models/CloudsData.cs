using System.Text.Json.Serialization;

namespace WeatherStation.Models;

public class CloudsData
{
    [JsonPropertyName("all")]
    public int Cloudiness { get; set; }
}