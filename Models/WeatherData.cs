using System.Text.Json.Serialization;

namespace WeatherStation.Models;

public class WeatherData
{
    [JsonPropertyName("main")]
    public MainData Main { get; set; }
    
    [JsonPropertyName("visibility")]
    public int? Visibility { get; set; }
    
    [JsonPropertyName("wind")]
    public WindData Wind { get; set; }
    
    [JsonPropertyName("clouds")]
    public CloudsData Clouds { get; set; }
    
    [JsonPropertyName("rain")]
    public PrecipitationData Rain { get; set; }
    
    [JsonPropertyName("snow")]
    public PrecipitationData Snow { get; set; }
}