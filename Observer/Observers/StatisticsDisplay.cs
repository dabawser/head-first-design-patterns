using Observer.Subjects;

namespace Observer.Observers;

public class StatisticsDisplay(WeatherData weatherData) : IObserver
{
    private double _minTemperature = double.MaxValue;
    private double _maxTemperature = double.MinValue;
    private double _temperatureSum;
    private int _temperatureMeasurementCount;

    private double _minHumidity = double.MaxValue;
    private double _maxHumidity = double.MinValue;
    private double _humiditySum;
    private int _humidityMeasurementCount;

    private int _minPressure = int.MaxValue;
    private int _maxPressure = int.MinValue;
    private int _pressureSum;
    private int _pressureMeasurementCount;

    public void Update()
    {
        var (tempAvg, tempMin, tempMax) = UpdateTemperatureStatistics();
        var (humAvg, humMin, humMax) = UpdateHumidityStatistics();
        var (presAvg, presMin, presMax) = UpdatePressureStatistics();

        Console.WriteLine($"Avg/Min/Max temperature = {tempAvg}/{tempMin}/{tempMax}");
        Console.WriteLine($"Avg/Min/Max humidity = {humAvg}/{humMin}/{humMax}");
        Console.WriteLine($"Avg/Min/Max pressure = {presAvg}/{presMin}/{presMax}");
    }

    private (double Avg, double Min, double Max) UpdateTemperatureStatistics()
    {
        var temperature = weatherData.GetTemperature();

        _temperatureSum += temperature;
        _temperatureMeasurementCount++;

        if (temperature < _minTemperature)
        {
            _minTemperature = temperature;
        }

        if (temperature > _maxTemperature)
        {
            _maxTemperature = temperature;
        }

        var averageTemperature = _temperatureSum / _temperatureMeasurementCount;

        return (averageTemperature, _minTemperature, _maxTemperature);
    }

    private (double Avg, double Min, double Max) UpdateHumidityStatistics()
    {
        var humidity = weatherData.GetHumidity();

        _humiditySum += humidity;
        _humidityMeasurementCount++;

        if (humidity < _minHumidity)
        {
            _minHumidity = humidity;
        }

        if (humidity > _maxHumidity)
        {
            _maxHumidity = humidity;
        }

        var averageHumidity = _humiditySum / _humidityMeasurementCount;

        return (averageHumidity, _minHumidity, _maxHumidity);
    }

    private (int Avg, int Min, int Max) UpdatePressureStatistics()
    {
        var pressure = weatherData.GetPressure();

        _pressureSum += pressure;
        _pressureMeasurementCount++;

        if (pressure < _minPressure)
        {
            _minPressure = pressure;
        }

        if (pressure > _maxPressure)
        {
            _maxPressure = pressure;
        }

        var averagePressure = _pressureSum / _pressureMeasurementCount;

        return (averagePressure, _minPressure, _maxPressure);
    }
}
