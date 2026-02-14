using Observer.Observers;

namespace Observer.Tests;

public class CurrentConditionsDisplayTests
{
    [Fact]
    public void Update_WhenCalled_ThenDisplaysCurrentConditions()
    {
        // Arrange
        const double temperature = 40.5;
        const double humidity = 80.0;
        const int pressure = 1013;
        var weatherDataMock = WeatherDataFixture.CreateWeatherDataMock(temperature, humidity, pressure);
        var currentConditionsDisplay = new CurrentConditionsDisplay(weatherDataMock);

        // Act
        currentConditionsDisplay.Update();

        // Assert
        Assert.Equal(
            $"Current conditions: {temperature}C degrees and {humidity}% humidity and {pressure} hPa pressure.\n",
            currentConditionsDisplay.Display());
    }
}
