package SoftwareEngineering.Lab1.Temperature;

public class Kelvin extends BaseTemperature {
    public Kelvin(double temperature) {
        // TODO Absolute zero on Celsius is 0K
        super(temperature);
    }

    public Celsius toCelsius() {
        return new Celsius(temperature - 273.15);
    }

    public Fahrenheit toFahrenheit() {
        return toCelsius().toFahrenheit();
    }

    public Kelvin toKelvin() {
        return new Kelvin(temperature);
    }
}