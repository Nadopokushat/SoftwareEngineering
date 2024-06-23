package SoftwareEngineering.Lab1.Temperature;

public interface ITemperature {
    public double getTemperature();
    public Celsius toCelsius();
    public Fahrenheit toFahrenheit();
    public Kelvin toKelvin();
}