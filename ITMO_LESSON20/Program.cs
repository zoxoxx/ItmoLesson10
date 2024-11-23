myDelegate my = Length;
my += Square;
my += Volume;
Console.Write("Введите радиус окружности:");
double parametrInput = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Длина окружности:{my?.Invoke(parametrInput)}");
my -= Volume;
Console.WriteLine($"Площадь круга:{my?.Invoke(parametrInput)}");
my -= Square;
Console.WriteLine($"Объем шара:{my?.Invoke(parametrInput)}");
static double Length(double parametr)
{
    double result = 2 * Math.PI * parametr;
    return result;
}
static double Square(double parametr)
{
    double result = Math.PI * Math.Pow(parametr, 2);
    return result;
}
static double Volume(double parametr)
{
    double result = 4 / 3 * Math.PI * Math.Pow(parametr, 3);
    return result;
}

delegate double myDelegate(double parametr);


