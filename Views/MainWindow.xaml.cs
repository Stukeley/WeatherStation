using System.Globalization;
using System.Windows;
using System.Windows.Input;
using WeatherStation.Services;

namespace WeatherStation.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void TopPanel_OnMouseDown(object sender, MouseButtonEventArgs e)
    {
        if (e.ChangedButton == MouseButton.Left)
        {
            this.DragMove();
        }
    }

    private void MinimizeButton_OnClick(object sender, RoutedEventArgs e)
    {
        this.WindowState = WindowState.Minimized;
    }

    private void ExitButton_OnClick(object sender, RoutedEventArgs e)
    {
        Application.Current.Shutdown();
    }

    private async void TestButton_OnClick(object sender, RoutedEventArgs e)
    {
        var data = await WeatherService.GetWeatherDataAsync("Bielsko-Biała", "Polska");
        
        MessageBox.Show(data.Main.Temperature.ToString());
    }

    private void ButtonCloseMenu_OnClick(object sender, RoutedEventArgs e)
    {
        ButtonCloseMenu.Visibility = Visibility.Collapsed;
        ButtonOpenMenu.Visibility = Visibility.Visible;
    }

    private void ButtonOpenMenu_OnClick(object sender, RoutedEventArgs e)
    {
        ButtonOpenMenu.Visibility = Visibility.Collapsed;
        ButtonCloseMenu.Visibility = Visibility.Visible;
    }

    private void Weather_OnPreviewMouseDown(object sender, MouseButtonEventArgs e)
    {
        MainFrame.Navigate(new Pages.WeatherPage());
    }

    private void Settings_OnPreviewMouseDown(object sender, MouseButtonEventArgs e)
    {
        MainFrame.Navigate(new Pages.SettingsPage());
    }
}