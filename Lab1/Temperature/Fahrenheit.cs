namespace Temperature;

class Fahrenheit : Temperature
{
    public Fahrenheit(double degrees) : base(degrees)
    {
        if (degrees < -459.67) throw new ArgumentException("Absolute zero on Fahrenheit is -459.67°F.");
    }

    public Celsius ToCelsius()
    {
        return new Celsius((this.value - 32) / 1.8);
    }

    public Kelvin ToKelvin()
    {
        return ToCelsius().ToKelvin();
    }
}
