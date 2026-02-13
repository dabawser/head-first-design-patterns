namespace Observer;

public record MeasurementStatistics(
    double TemperatureAverage,
    double TemperatureMin,
    double TemperatureMax,
    double HumidityAverage,
    double HumidityMin,
    double HumidityMax,
    int PressureAverage,
    int PressureMin,
    int PressureMax);
