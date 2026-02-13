using Observer.Subjects;

namespace Observer.Observers;

public class ForecastDisplay(WeatherData weatherData) : IObserver
{
    private double _currentTemperature;
    private double _lastTemperature;

    public void Update()
    {
        _lastTemperature = _currentTemperature;
        _currentTemperature = weatherData.GetTemperature();

        Display();
    }

    private void Display()
    {
        Console.WriteLine("Forecast: ");

        if (_currentTemperature > _lastTemperature)
        {
            Console.WriteLine("Warming trend - expect warmer weather!");
        }
        else if (_currentTemperature.Equals(_lastTemperature))
        {
            Console.WriteLine("More of the same");
        }
        else
        {
            Console.WriteLine("Cooling trend - expect cooler weather");
        }
    }
}
