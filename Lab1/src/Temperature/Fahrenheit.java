package SoftwareEngineering.Lab1.Temperature;

public class Fahrenheit extends BaseTemperature {
    public Fahrenheit(double temperature) {
        // TODO Absolute zero on Fahrenheit is -459.67°F
        super(temperature);
    }

    public Celsius toCelsius() {
        return new Celsius((temperature - 32) / 1.8);
    }

    public Fahrenheit toFahrenheit() {
        return new Fahrenheit(temperature);
    }

    public Kelvin toKelvin() {
        return toCelsius().toKelvin();
    }
}