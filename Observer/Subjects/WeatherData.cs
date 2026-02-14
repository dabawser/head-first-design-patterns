using Observer.Observers;

namespace Observer.Subjects;

public class WeatherData : IWeatherSubject
{
    private readonly List<IWeatherObserver> _observers = new();
    private readonly Random _random = new();

    public void RegisterObserver(IWeatherObserver weatherObserver)
    {
        _observers.Add(weatherObserver);
    }

    public void RemoveObserver(IWeatherObserver weatherObserver)
    {
        _observers.Remove(weatherObserver);
    }

    public void NotifyObservers()
    {
        _observers.ForEach(observer => observer.Update());
    }

    public void MeasurementsChanged()
    {
        NotifyObservers();
    }

    public virtual double GetTemperature() => -40.0d + (_random.NextDouble() * 99.9d);

    public virtual double GetHumidity() => _random.Next(0, 101);

    public virtual int GetPressure() => _random.Next(970, 1051);
}
