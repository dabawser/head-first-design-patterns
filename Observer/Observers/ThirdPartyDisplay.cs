using System.Text;
using Observer.Subjects;

namespace Observer.Observers;

public class ThirdPartyDisplay : IWeatherObserver, IDisplay
{
    private readonly IWeatherSubject _weatherSubject;
    private int _currentTemperature;
    private int _currentHumidity;
    private int _currentPressure;

    public ThirdPartyDisplay(IWeatherSubject weatherSubject)
    {
        _weatherSubject = weatherSubject;
        _weatherSubject.RegisterObserver(this);
    }

    ~ThirdPartyDisplay()
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
        stringBuilder.AppendLine("=== Third Party Weather Display ===");
        stringBuilder.AppendLine($"Temperature: {_currentTemperature}°C");
        stringBuilder.AppendLine($"Humidity: {_currentHumidity}%");
        stringBuilder.AppendLine($"Pressure: {_currentPressure} hPa");
        stringBuilder.Append("===================================");
        var output = stringBuilder.ToString();
        Console.WriteLine(output);

        return output;
    }
}
