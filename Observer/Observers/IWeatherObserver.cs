namespace Observer.Observers;

/// <summary>
/// The IObserver interface defines the contract for an observer in the Observer design pattern. It requires
/// implementing classes to define the Update method, which will be called by the subject to notify the observer of
/// changes in the subject's state.
/// </summary>
public interface IWeatherObserver
{
    /// <summary>
    /// The Update method is called by the subject to notify the observer of changes in the subject's state. When this
    /// method is called, the observer can react to the change in the subject's state, such as by updating its own
    /// state or performing some action based on the new state of the subject. This method is a key part of the
    /// Observer design pattern, as it allows for a decoupled way of notifying observers about changes in the subject's
    /// state without the subject needing to know the details of the observers.
    /// </summary>
    void Update();
}
