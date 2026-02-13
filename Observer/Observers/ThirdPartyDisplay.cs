using Observer.Subjects;

namespace Observer.Observers;

public class ThirdPartyDisplay(WeatherData weatherData) : IObserver
{
    public void Update()
    {
        var temperature = weatherData.GetTemperature();
        var humidity = weatherData.GetHumidity();
        var pressure = weatherData.GetPressure();

        Console.WriteLine("=== Third Party Weather Display ===");
        Console.WriteLine($"Temperature: {temperature:F1}°C");
        Console.WriteLine($"Humidity: {humidity}%");
        Console.WriteLine($"Pressure: {pressure} hPa");
        Console.WriteLine("===================================");
    }
}
