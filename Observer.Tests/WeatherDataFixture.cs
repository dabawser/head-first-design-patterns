using Moq;
using Observer.Subjects;

namespace Observer.Tests;

public static class WeatherDataFixture
{
    public static WeatherData CreateWeatherDataMock(int temperature = 40, int humidity = 85, int pressure = 1000)
    {
        var weatherDataMock = new Mock<WeatherData>();

        weatherDataMock.Setup(x => x.GetTemperature()).Returns(temperature);
        weatherDataMock.Setup(x => x.GetHumidity()).Returns(humidity);
        weatherDataMock.Setup(x => x.GetPressure()).Returns(pressure);

        return weatherDataMock.Object;
    }
}
