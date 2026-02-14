using Observer.Observers;

namespace Observer.Subjects;

/// <summary>
/// The ISubject interface defines the contract for a subject in the Observer design pattern. It allows observers to
/// register, remove, and be notified of changes in the subject's state.
/// </summary>
public interface IWeatherSubject
{
    /// <summary>
    /// Registers an observer to receive updates from the subject. When the subject's state changes, it will notify all
    /// registered observers by calling their Update method. This allows observers to react to changes in the subject's
    /// state.
    /// </summary>
    void RegisterObserver(IWeatherObserver weatherObserver);

    /// <summary>
    /// Removes an observer from the list of registered observers. After an observer is removed, it will no longer
    /// receive updates from the subject when the subject's state changes. This allows observers to stop receiving
    /// notifications when they are no longer interested in the subject's state changes.
    /// </summary>
    void RemoveObserver(IWeatherObserver weatherObserver);

    /// <summary>
    /// Notifies all registered observers of a change in the subject's state. When this method is called, the subject
    /// will iterate through its list of registered observers and call their Update method, allowing them to react
    /// accordingly to the change in the subject's state. This is a key part of the Observer design pattern, as it
    /// allows for a decoupled way of notifying observers about changes in the subject's state without the subject
    /// needing to know the details of the observers.
    /// </summary>
    void NotifyObservers();

    /// <summary>
    /// Indicates that the measurements have changed and that observers should be notified. This method is typically
    /// called when the subject's state changes, such as when new weather data is available.
    /// </summary>
    int GetTemperature();

    /// <summary>
    /// Gets the current humidity level. This method is typically called by observers to retrieve the latest humidity
    /// data from the subject. The subject will return the current humidity level, which observers can then use to
    /// update their displays or perform other actions based on the new humidity data.
    /// </summary>
    int GetHumidity();

    /// <summary>
    /// Gets the current pressure level. This method is typically called by observers to retrieve the latest pressure
    /// data from the subject. The subject will return the current pressure level, which observers can then use to
    /// update their displays or perform other actions based on the new pressure data.
    /// </summary>
    int GetPressure();
}
