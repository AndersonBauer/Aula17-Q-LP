public static class ConversorTemperatura
{
    public static double CelsiusParaFarhenheith(double celcius)
    {
        return (celcius * 5/9) + 32;
    }
    public static double FarhenheithParaCelsius(double farhenheith)
    {
        return (farhenheith  - 32) * 5/9;
    }
}