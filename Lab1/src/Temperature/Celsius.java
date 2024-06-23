package SoftwareEngineering.Lab1.Temperature;

public class Celsius extends BaseTemperature {
    public Celsius(double temperature) {
        // TODO Absolute zero on Celsius is −273.15°C
        super(temperature);
    }

    public Celsius toCelsius() {
        return new Celsius(temperature);
    }

    public Fahrenheit toFahrenheit() {
        return new Fahrenheit(temperature * 1.8 + 32);
    }

    public Kelvin toKelvin() {
        return new Kelvin(temperature + 273.15);
    }
}