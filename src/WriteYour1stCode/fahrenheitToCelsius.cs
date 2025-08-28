int fahrenheit = 94;

static double convFtoC(int fahrenheit)
{
    return ((fahrenheit - 32.0) * (5.0 / 9.0));
}

double celsius = convFtoC(fahrenheit);

Console.WriteLine($" The temperature is  {convFtoC(fahrenheit)} Celsius"); 