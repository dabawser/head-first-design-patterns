using Observer.Observers;

namespace Observer.Tests;

public class ForecastDisplayTests
{
    [Fact]
    public void Update_WhenCalled_ThenDisplaysForecast()
    {
        // Arrange
        const double temperature = 40.2;
        const double humidity = 75.0;
        const int pressure = 1010;

        var weatherDataMock = WeatherDataFixture.CreateWeatherDataMock(temperature, humidity, pressure);
        var forecastDisplay = new ForecastDisplay(weatherDataMock);

        // Act
        forecastDisplay.Update();
        var displayOutput = forecastDisplay.Display();

        // Assert
        Assert.Equal("Forecast: \nWarming trend - expect warmer weather!\n", displayOutput);
    }
}
