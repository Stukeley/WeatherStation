namespace WeatherStation.Helpers;

public static class ValidationHelper
{
    public static bool ValidateLatitudeString(string latitude)
    {
        latitude = latitude.Replace(".", ",");
        return double.TryParse(latitude, out var lat) && ValidateLatitude(lat);
    }
    
    public static bool ValidateLongitudeString(string longitude)
    {
        longitude = longitude.Replace(".", ",");
        return double.TryParse(longitude, out var lon) && ValidateLongitude(lon);
    }

    private static bool ValidateLatitude(double latitude)
    {
        return latitude >= -90 && latitude <= 90;
    }

    private static bool ValidateLongitude(double longitude)
    {
        return longitude >= -180 && longitude <= 180;
    }
}