using Observer.Observers;
using Observer.Subjects;

var weatherStation = new WeatherData();

var currentConditionsDisplay = new CurrentConditionsDisplay(weatherStation);
var statisticsDisplay = new StatisticsDisplay(weatherStation);
var forecastDisplay = new ForecastDisplay(weatherStation);
var thirdPartyDisplay = new ThirdPartyDisplay(weatherStation);

weatherStation.RegisterObserver(currentConditionsDisplay);
weatherStation.RegisterObserver(statisticsDisplay);
weatherStation.RegisterObserver(forecastDisplay);
weatherStation.RegisterObserver(thirdPartyDisplay);

weatherStation.MeasurementsChanged();
