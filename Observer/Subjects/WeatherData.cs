using Observer.Observers;

namespace Observer.Subjects;

public class WeatherData() : ISubject
{
    private readonly List<IObserver> _observers = new();
    private readonly Random _random = new();

    public void RegisterObserver(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void NotifyObservers()
    {
        _observers.ForEach(observer => observer.Update());
    }

    public void MeasurementsChanged()
    {
        NotifyObservers();
    }

    public double GetTemperature()
    {
        // Returns temperature in Celsius between 40.0°C and 59.9°C
        return 40.0d + (_random.NextDouble() * 19.9d);
    }

    public int GetHumidity()
    {
        // Returns humidity percentage between 0% and 100%
        return _random.Next(0, 101);
    }

    public int GetPressure()
    {
        // Returns pressure in hectopascals between 970 hPa and 1050 hPa
        return _random.Next(970, 1051);
    }
}
