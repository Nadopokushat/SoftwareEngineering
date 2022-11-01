namespace Temperature;

class Kelvin : Temperature
{
    public Kelvin(double kelvin) : base(kelvin)
    {
        if (kelvin < 0) throw new ArgumentException("Absolute zero on Celsius is 0K.");
    }

    public Celsius ToCelsius()
    {
        return new Celsius(this.value - 273.15);
    }

    public Fahrenheit ToFahrenheit()
    {
        return ToCelsius().ToFahrenheit();
    }
}
