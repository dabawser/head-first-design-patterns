using System.Text;
using Observer.Subjects;

namespace Observer.Observers;

public class CurrentConditionsDisplay(IWeatherSubject weatherSubject) : IWeatherObserver, IDisplay
{
    private double _currentTemperature;
    private double _currentHumidity;
    private int _currentPressure;

    public void Update()
    {
        _currentTemperature = weatherSubject.GetTemperature();
        _currentHumidity = weatherSubject.GetHumidity();
        _currentPressure = weatherSubject.GetPressure();

        Display();
    }

    public string Display()
    {
        var stringBuilder = new StringBuilder();
        stringBuilder.AppendLine($"Current conditions: {_currentTemperature}C degrees and {_currentHumidity}% humidity and {_currentPressure} hPa pressure.");

        var output = stringBuilder.ToString();
        Console.WriteLine(output);

        return output;
    }
}
