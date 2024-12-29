using System.Text.Json.Serialization;

namespace WeatherStation.Models;

public class PrecipitationData
{
    [JsonPropertyName("1h")]
    public double? OneHour { get; set; }
}