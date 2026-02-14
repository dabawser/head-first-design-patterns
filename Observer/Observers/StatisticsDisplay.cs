using System.Text;
using Observer.Subjects;

namespace Observer.Observers;

public class StatisticsDisplay : IWeatherObserver, IDisplay
{
    private readonly IWeatherSubject _weatherSubject;
    private readonly MeasurementStatistics _measurementStatistics = new();
    private double _temperatureSum;
    private int _temperatureMeasurementCount;
    private double _humiditySum;
    private int _humidityMeasurementCount;
    private double _pressureSum;
    private int _pressureMeasurementCount;

    public StatisticsDisplay(IWeatherSubject weatherSubject)
    {
        _weatherSubject = weatherSubject;
        _weatherSubject.RegisterObserver(this);
    }

    ~StatisticsDisplay()
    {
        _weatherSubject.RemoveObserver(this);
    }

    public void Update()
    {
        UpdateTemperatureStatistics();
        UpdateHumidityStatistics();
        UpdatePressureStatistics();

        Display();
    }

    public string Display()
    {
        var stringBuilder = new StringBuilder();

        stringBuilder.AppendLine($"Avg/Min/Max temperature = {_measurementStatistics.TemperatureAverage}/{_measurementStatistics.TemperatureMin}/{_measurementStatistics.TemperatureMax}");
        stringBuilder.AppendLine($"Avg/Min/Max humidity = {_measurementStatistics.HumidityAverage}/{_measurementStatistics.HumidityMin}/{_measurementStatistics.HumidityMax}");
        stringBuilder.AppendLine($"Avg/Min/Max pressure = {_measurementStatistics.PressureAverage}/{_measurementStatistics.PressureMin}/{_measurementStatistics.PressureMax}");

        var output = stringBuilder.ToString();
        Console.WriteLine(output);

        return output;
    }

    private void UpdateTemperatureStatistics()
    {
        var temperature = _weatherSubject.GetTemperature();

        _temperatureSum += temperature;
        _temperatureMeasurementCount++;

        if (temperature < _measurementStatistics.TemperatureMin)
        {
            _measurementStatistics.TemperatureMin = temperature;
        }

        if (temperature > _measurementStatistics.TemperatureMax)
        {
            _measurementStatistics.TemperatureMax = temperature;
        }

        _measurementStatistics.TemperatureAverage = _temperatureSum / _temperatureMeasurementCount;
    }

    private void UpdateHumidityStatistics()
    {
        var humidity = _weatherSubject.GetHumidity();

        _humiditySum += humidity;
        _humidityMeasurementCount++;

        if (humidity < _measurementStatistics.HumidityMin)
        {
            _measurementStatistics.HumidityMin = humidity;
        }

        if (humidity > _measurementStatistics.HumidityMax)
        {
            _measurementStatistics.HumidityMax = humidity;
        }

        _measurementStatistics.HumidityAverage = _humiditySum / _humidityMeasurementCount;
    }

    private void UpdatePressureStatistics()
    {
        var pressure = _weatherSubject.GetPressure();

        _pressureSum += pressure;
        _pressureMeasurementCount++;

        if (pressure < _measurementStatistics.PressureMin)
        {
            _measurementStatistics.PressureMin = pressure;
        }

        if (pressure > _measurementStatistics.PressureMax)
        {
            _measurementStatistics.PressureMax = pressure;
        }

        _measurementStatistics.PressureAverage = _pressureSum / _pressureMeasurementCount;
    }
}
