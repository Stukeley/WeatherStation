using System.IO;

namespace WeatherStation.Helpers;

public class ApiKeyHelper
{
    public static readonly string ApiKey;

    // Wczytanie klucza API z pliku.
    // NIGDY NIE NALEŻY PRZECHOWYWAĆ DANYCH WRAŻLIWYCH BEZPOŚREDNIO!
    static ApiKeyHelper()
    {
        string path = Path.Combine(Environment.CurrentDirectory, @"Assets\Keys\WeatherApiKey.txt");
        ApiKey = File.ReadAllText(path);
    }
}