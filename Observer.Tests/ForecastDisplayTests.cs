using Moq;
using Observer.Observers;
using Observer.Subjects;

namespace Observer.Tests;

[Collection(nameof(ConsoleOutputFixture))]
public class ForecastDisplayTests
{
    [Fact]
    public void Update_WhenCalled_ThenDisplaysForecast()
    {
        // Arrange
        using var fixture = new ConsoleOutputFixture();
        var weatherDataMock = new Mock<WeatherData>();
        var forecastDisplay = new ForecastDisplay(weatherDataMock.Object);

        // Act
        forecastDisplay.Update();

        // Assert
        var output = fixture.GetOutput();
        Assert.Contains("Forecast:", output);
    }
}
