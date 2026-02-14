using Observer.Observers;

namespace Observer.Tests;

public class StatisticsDisplayTests
{
    [Fact]
    public void Update_WhenCalled_ThenDisplaysMeasurementStatistics()
    {
        // Arrange
        var weatherSubject = DisplayFixture.CreateWeatherSubject();
        var statisticsDisplay = new StatisticsDisplay(weatherSubject);

        // Act
        statisticsDisplay.Update();

        // Assert
        Assert.Equal(
            "Avg/Min/Max temperature = 40/0/40\nAvg/Min/Max humidity = 85/0/85\nAvg/Min/Max pressure = 1000/0/1000\n",
            statisticsDisplay.Display());
    }
}
