using System.Text;
using Observer.Observers;

namespace Observer.Tests;

public class ThirdPartyDisplayTests
{
    [Fact]
    public void Update_WhenCalled_ThenDisplaysThirdPartyData()
    {
        // Arrange
        var expectedOutput = CreateExpectedOutput();
        var weatherDataMock = WeatherDataFixture.CreateWeatherDataMock();
        var thirdPartyDisplay = new ThirdPartyDisplay(weatherDataMock);

        // Act
        thirdPartyDisplay.Update();
        var displayOutput = thirdPartyDisplay.Display();

        // Assert
        Assert.Equal(expectedOutput, displayOutput);
    }

    private static string CreateExpectedOutput()
    {
        var stringBuilder = new StringBuilder();
        stringBuilder.AppendLine("=== Third Party Weather Display ===");
        stringBuilder.AppendLine("Temperature: 40,5°C");
        stringBuilder.AppendLine("Humidity: 85,5%");
        stringBuilder.AppendLine("Pressure: 1000 hPa");
        stringBuilder.Append("===================================");
        return stringBuilder.ToString();
    }
}
