using System.Text;
using Observer.Subjects;

namespace Observer.Observers;

public class ForecastDisplay : IWeatherObserver, IDisplay
{
    private readonly IWeatherSubject _weatherSubject;
    private int _currentTemperature;
    private int _lastTemperature = 20;

    public ForecastDisplay(IWeatherSubject weatherSubject)
    {
        _weatherSubject = weatherSubject;
        _weatherSubject.RegisterObserver(this);
    }

    ~ForecastDisplay()
    {
        _weatherSubject.RemoveObserver(this);
    }

    public void Update()
    {
        _lastTemperature = _currentTemperature;
        _currentTemperature = _weatherSubject.GetTemperature();

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
