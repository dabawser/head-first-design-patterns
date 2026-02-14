using System.Text;
using Observer.Subjects;

namespace Observer.Observers;

public class ForecastDisplay(WeatherData weatherData) : IWeatherObserver, IDisplay
{
    private double _currentTemperature;
    private double _lastTemperature = 20.0;

    public void Update()
    {
        _lastTemperature = _currentTemperature;
        _currentTemperature = weatherData.GetTemperature();

        Display();
    }

    public string Display()
    {
        var stringBuilder = new StringBuilder();
        stringBuilder.AppendLine("Forecast: ");

        if (_currentTemperature > _lastTemperature)
        {
            stringBuilder.AppendLine("Warming trend - expect warmer weather!");
        }
        else if (_currentTemperature.Equals(_lastTemperature))
        {
            stringBuilder.AppendLine("More of the same");
        }
        else
        {
            stringBuilder.AppendLine("Cooling trend - expect cooler weather");
        }

        var output = stringBuilder.ToString();
        Console.WriteLine(output);

        return output;
    }
}
