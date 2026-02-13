using Observer.Subjects;

namespace Observer.Observers;

public class CurrentConditionsDisplay(WeatherData weatherData) : IObserver
{
    public void Update()
    {
        var temperature = weatherData.GetTemperature();
        var humidity = weatherData.GetHumidity();
        var pressure = weatherData.GetPressure();

        Console.WriteLine($"Current conditions: {temperature}C degrees and {humidity}% humidity and {pressure} hPa pressure");
    }
}
