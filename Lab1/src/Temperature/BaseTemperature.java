package SoftwareEngineering.Lab1.Temperature;

public abstract class BaseTemperature implements ITemperature {
    protected double temperature;

    public BaseTemperature(double temperature) {
        this.temperature = temperature;
    }

    public double getTemperature() {
        return temperature;
    }
}