using Observer.Observers;
using Observer.Subjects;

var weatherStation = new WeatherData();

_ = new CurrentConditionsDisplay(weatherStation);
_ = new StatisticsDisplay(weatherStation);
_ = new ForecastDisplay(weatherStation);
_ = new ThirdPartyDisplay(weatherStation);

weatherStation.MeasurementsChanged();
weatherStation.MeasurementsChanged();
weatherStation.MeasurementsChanged();
weatherStation.MeasurementsChanged();
weatherStation.MeasurementsChanged();
