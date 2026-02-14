using Observer.Observers;

namespace Observer.Tests;

public class ForecastDisplayTests
{
    [Fact]
    public void Update_WhenCalled_ThenDisplaysForecast()
    {
        // Arrange
        const int temperature = 40;
        const int humidity = 75;
        const int pressure = 1010;

        var weatherSubject = DisplayFixture.CreateWeatherSubject(temperature, humidity, pressure);
        var forecastDisplay = new ForecastDisplay(weatherSubject);

        // Act
        forecastDisplay.Update();
        var displayOutput = forecastDisplay.Display();

        // Assert
        Assert.Equal("Forecast: \nWarming trend - expect warmer weather!\n", displayOutput);
    }
}
