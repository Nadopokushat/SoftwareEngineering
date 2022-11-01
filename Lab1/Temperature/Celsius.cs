namespace Temperature;

class Celsius : Temperature
{
    public Celsius(double degrees) : base(degrees)
    {
        if (degrees < -273.15) throw new ArgumentException("Absolute zero on Celsius is −273.15°C.");
    }

    public Fahrenheit ToFahrenheit()
    {
        return new Fahrenheit(this.value * 1.8 + 32);
    }

    public Kelvin ToKelvin()
    {
        return new Kelvin(this.value + 273.15);
    }
}
