Console.Write("Введите число длдя которого необходимо получить факториал:");
double input = Convert.ToInt32(Console.ReadLine());
await FactotialAsync(input);
Console.WriteLine("Main отработал");
static async Task FactotialAsync (double number)
{
    Console.WriteLine("Начали считать факториал.");
    double result = await Task.Run(() => Calculate(number));
    Console.WriteLine("Закончили считать факториал.");
    Console.WriteLine($"Факториал:{result} Числа:{number}");
    Thread.Sleep(3000); 
}
static double Calculate(double number)
{
    double factorial = 1;
    for (int i = 1; i <= number; i++)
    {
        factorial *= i;
        Thread.Sleep(500);
    }
    return factorial;
}