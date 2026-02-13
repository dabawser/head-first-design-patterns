using Moq;
using Observer.Observers;
using Observer.Subjects;

namespace Observer.Tests;

[Collection(nameof(ConsoleOutputFixture))]
public class CurrentConditionsDisplayTests
{
    [Fact]
    public void Update_WhenCalled_ThenDisplaysCurrentConditions()
    {
        // Arrange
        using var fixture = new ConsoleOutputFixture();
        var weatherDataMock = new Mock<WeatherData>();
        var currentConditionsDisplay = new CurrentConditionsDisplay(weatherDataMock.Object);

        // Act
        currentConditionsDisplay.Update();

        // Assert
        var output = fixture.GetOutput();
        Assert.Contains("Current conditions", output);
    }
}
