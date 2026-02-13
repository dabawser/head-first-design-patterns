using Moq;
using Observer.Observers;
using Observer.Subjects;

namespace Observer.Tests;

public class ThirdPartyDisplayTests
{
    [Fact]
    public void Update_WhenCalled_ThenDisplaysThirdPartyData()
    {
        // Arrange
        using var fixture = new ConsoleOutputFixture();
        var weatherDataMock = new Mock<WeatherData>();
        var thirdPartyDisplay = new ThirdPartyDisplay(weatherDataMock.Object);

        // Act
        thirdPartyDisplay.Update();

        // Assert
        var output = fixture.GetOutput();
        Assert.Contains("=== Third Party Weather Display ===", output);
    }
}
