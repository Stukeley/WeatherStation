using System.Windows;
using System.Windows.Controls;
using WeatherStation.Helpers;
using WeatherStation.Models;
using WeatherStation.Services;

namespace WeatherStation.Views.Pages;

public partial class WeatherPage : Page
{
    private WeatherData _weatherData;
    
    public WeatherPage()
    {
        InitializeComponent();
    }

    private void CoordinatesRadioButton_OnChecked(object sender, RoutedEventArgs e)
    {
        CoordinatesPanel.Visibility = Visibility.Visible;
        CityCountryPanel.Visibility = Visibility.Collapsed;
    }

    private void LocationRadioButton_OnChecked(object sender, RoutedEventArgs e)
    {
        CoordinatesPanel.Visibility = Visibility.Collapsed;
        CityCountryPanel.Visibility = Visibility.Visible;
    }

    private async void WeatherButton_OnClick(object sender, RoutedEventArgs e)
    {
        // Wyłącz tymczasowo przycisk aby nie można było wysłać zapytania ponownie przed zwróceniem danych.
        (sender as Button).IsEnabled = false;
        
        // Sprawdzenie, czy którakolwiek opcja jest zaznaczona.
        if (CoordinatesRadioButton.IsChecked == false && LocationRadioButton.IsChecked == false)
        {
            MessageBox.Show("Wybierz jedną z opcji wprowadzania danych.");
            (sender as Button).IsEnabled = true;
            return;
        }
        
        // Jeżeli wybrano opcję wprowadzania współrzędnych geograficznych.
        if (CoordinatesRadioButton.IsChecked == true)
        {
            double latitude, longitude;
            
            // Walidacja wprowadzonych danych.
            if (!ValidationHelper.ValidateLatitudeString(LatitudeTextBox.Text) || !ValidationHelper.ValidateLongitudeString(LongitudeTextBox.Text))
            {
                MessageBox.Show("Wprowadzono nieprawidłowe współrzędne geograficzne.");
                (sender as Button).IsEnabled = true;
                return;
            }
            
            latitude = double.Parse(LatitudeTextBox.Text.Replace(".", ","));
            longitude = double.Parse(LongitudeTextBox.Text.Replace(".", ","));
            
            // Pobranie danych pogodowych.
            var data = await WeatherService.GetWeatherDataAsync(latitude, longitude);

            _weatherData = data;
        }
        else
        {
            string city = CityTextBox.Text;
            string country = CountryTextBox.Text;
            
            // Pobranie danych pogodowych.
            var data = await WeatherService.GetWeatherDataAsync(city, country);

            _weatherData = data;
        }
        
        this.DataContext = _weatherData;
        WeatherGrid.Visibility = Visibility.Visible;
        
        (sender as Button).IsEnabled = true;
    }
}