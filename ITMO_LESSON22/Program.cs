Console.Write("Введите размер массива:");
int sizeArray = Convert.ToInt32(Console.ReadLine());
int[] array = new int[sizeArray];
Random random = new Random();
int currentNumber = 0;
for (int i = 0; i < sizeArray; i++)
{
    currentNumber = random.Next(1, 10);
    array[i] = currentNumber;
}

Task task1 = new Task(() => SumArray(array));
Action<Task, object> action = new Action<Task, object>(MaxArray);

Task task2 = task1.ContinueWith(action, array);
task1.Start();
task2.Wait();
Console.WriteLine("Программа завершена\n");
Console.WriteLine("Весь массив для проверки:");
foreach (int i in array)
{
    Console.WriteLine(i);
}

static void SumArray(int[] array)
{
    Console.WriteLine($"Сумма элементов массива: {array.Sum()}");
    Thread.Sleep(2000);
}

static void MaxArray(Task task, object array)
{
    int[] currentArray = (int[])array;
    Console.WriteLine($"Максимальное число в массиве: {currentArray.Max()}");
    Thread.Sleep(2000);
}