using Moq;
using Observer.Observers;
using Observer.Subjects;

namespace Observer.Tests;

[Collection(nameof(ConsoleOutputFixture))]
public class StatisticsDisplayTests
{
    [Fact]
    public void Update_WhenCalled_ThenDisplaysTemperatureStatistics()
    {
        // Arrange
        using var fixture = new ConsoleOutputFixture();
        var weatherDataMock = new Mock<WeatherData>();
        var statisticsDisplay = new StatisticsDisplay(weatherDataMock.Object);

        // Act
        statisticsDisplay.Update();

        // Assert
        Assert.Contains("Avg/Min/Max temperature", fixture.GetOutput());
    }

    [Fact]
    public void Update_WhenCalled_ThenDisplaysHumidityStatistics()
    {
        // Arrange
        using var fixture = new ConsoleOutputFixture();
        var weatherDataMock = new Mock<WeatherData>();
        var statisticsDisplay = new StatisticsDisplay(weatherDataMock.Object);

        // Act
        statisticsDisplay.Update();

        // Assert
        Assert.Contains("Avg/Min/Max humidity", fixture.GetOutput());
    }

    [Fact]
    public void Update_WhenCalled_ThenDisplaysPressureStatistics()
    {
        // Arrange
        using var fixture = new ConsoleOutputFixture();
        var weatherDataMock = new Mock<WeatherData>();
        var statisticsDisplay = new StatisticsDisplay(weatherDataMock.Object);

        // Act
        statisticsDisplay.Update();

        // Assert
        Assert.Contains("Avg/Min/Max pressure", fixture.GetOutput());
    }
}
