using System.Text;
using Observer.Subjects;

namespace Observer.Observers;

public class CurrentConditionsDisplay : IWeatherObserver, IDisplay
{
    private readonly IWeatherSubject _weatherSubject;
    private int _currentTemperature;
    private int _currentHumidity;
    private int _currentPressure;

    public CurrentConditionsDisplay(IWeatherSubject weatherSubject)
    {
        _weatherSubject = weatherSubject;
        _weatherSubject.RegisterObserver(this);
    }

    ~CurrentConditionsDisplay()
    {
        _weatherSubject.RemoveObserver(this);
    }

    public void Update()
    {
        _currentTemperature = _weatherSubject.GetTemperature();
        _currentHumidity = _weatherSubject.GetHumidity();
        _currentPressure = _weatherSubject.GetPressure();

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
