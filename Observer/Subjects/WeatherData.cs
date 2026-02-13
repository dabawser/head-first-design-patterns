using Observer.Observers;

namespace Observer.Subjects;

public class WeatherData : ISubject
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

    public double GetTemperature() => 40.0d + (_random.NextDouble() * 19.9d);

    public int GetHumidity() => _random.Next(0, 101);

    public int GetPressure() => _random.Next(970, 1051);
}
