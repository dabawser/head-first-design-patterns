using System.Text;
using Observer.Subjects;

namespace Observer.Observers;

public class ThirdPartyDisplay(IWeatherSubject weatherSubject) : IWeatherObserver, IDisplay
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
