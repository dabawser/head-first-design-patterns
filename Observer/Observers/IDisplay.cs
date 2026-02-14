namespace Observer.Observers;

/// <summary>
/// Interface for display elements that can be registered with the WeatherData subject to receive updates and display
/// weather information.
/// </summary>
public interface IDisplay
{
    /// <summary>
    /// The Display method is responsible for displaying the current weather information from display element.
    /// </summary>
    string Display();
}
