using Moq;
using Observer.Observers;
using Observer.Subjects;

namespace Observer.Tests;

public class WeatherDataTests
{
    [Fact]
    public void WeatherData_WhenMeasurementsChanged_ThenNotifiesObservers()
    {
        // Arrange
        var weatherData = new WeatherData();
        var observer1 = new Mock<IWeatherObserver>();
        var observer2 = new Mock<IWeatherObserver>();
        weatherData.RegisterObserver(observer1.Object);
        weatherData.RegisterObserver(observer2.Object);

        // Act
        weatherData.MeasurementsChanged();

        // Assert
        observer1.Verify(x => x.Update(), Times.Once);
        observer2.Verify(x => x.Update(), Times.Once);
    }

    [Fact]
    public void WeatherData_WhenRemoveObserver_ThenDoesNotNotifyRemovedObserver()
    {
        // Arrange
        var weatherData = new WeatherData();
        var observer1 = new Mock<IWeatherObserver>();
        var observer2 = new Mock<IWeatherObserver>();
        weatherData.RegisterObserver(observer1.Object);
        weatherData.RegisterObserver(observer2.Object);
        weatherData.RemoveObserver(observer1.Object);

        // Act
        weatherData.MeasurementsChanged();

        // Assert
        observer1.Verify(x => x.Update(), Times.Never);
        observer2.Verify(x => x.Update(), Times.Once);
    }

    [Fact]
    public void WeatherData_Getters_ReturnValuesInExpectedRanges()
    {
        // Arrange
        var weatherData = new WeatherData();

        // Act
        var temperature = weatherData.GetTemperature();
        var humidity = weatherData.GetHumidity();
        var pressure = weatherData.GetPressure();

        // Assert
        Assert.InRange(temperature, -40, 60);
        Assert.InRange(humidity, 0, 100);
        Assert.InRange(pressure, 970, 1050);
    }
}
