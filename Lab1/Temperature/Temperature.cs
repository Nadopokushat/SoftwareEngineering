namespace Temperature;

abstract class Temperature
{
    private protected double value;

    public Temperature(double value)
    {
        this.value = value;
    }

    public double GetTemperature() => value;
}
