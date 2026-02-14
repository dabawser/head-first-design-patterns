using Observer.Observers;

namespace Observer.Tests;

public class StatisticsDisplayTests
{
    [Fact]
    public void Update_WhenCalled_ThenDisplaysMeasurementStatistics()
    {
        // Arrange
        var weatherDataMock = WeatherDataFixture.CreateWeatherDataMock();
        var statisticsDisplay = new StatisticsDisplay(weatherDataMock);

        // Act
        statisticsDisplay.Update();

        // Assert
        Assert.Equal(
            "Avg/Min/Max temperature = 40,5/0/40,5\nAvg/Min/Max humidity = 85,5/0/85,5\nAvg/Min/Max pressure = 1000/0/1000\n",
            statisticsDisplay.Display());
    }
}
