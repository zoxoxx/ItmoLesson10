Thread second = new Thread(Sad.WorkSecond);
second.Start();
Sad.Work();
second.Join();
Sad.PrintGarden();

class Sad
{
    public static bool[,] earthArray = new bool[3, 3] { { false, false, false }, { false, false, false }, { false, false, false } };

    public static void Work()
    {
        for (int i = 0; i < earthArray.GetLength(0); i++)
        {
            for (int j = 0; j < earthArray.GetLength(1); j++)
            {
                Thread.Sleep(500);
                if (!earthArray[i, j])
                {
                    earthArray[i, j] = true;
                    Console.WriteLine($"Садовник 1 заполнил клетку ({i}, {j})");
                }
            }
        }
    }

    public static void WorkSecond()
    {
        for (int i = earthArray.GetLength(0) - 1; i >= 0; i--)
        {
            for (int j = earthArray.GetLength(1) - 1; j >= 0; j--)
            {
                Thread.Sleep(500);
                if (!earthArray[i, j])
                {
                    earthArray[i, j] = true;
                    Console.WriteLine($"Садовник 2 заполнил клетку ({i}, {j})");
                }
            }
        }
    }

    public static void PrintGarden()
    {
        Console.WriteLine("\nИтоговое состояние сада:");
        for (int i = 0; i < earthArray.GetLength(0); i++)
        {
            for (int j = 0; j < earthArray.GetLength(1); j++)
            {
                Console.Write(earthArray[i, j] ? "1 " : "0 ");
            }
            Console.WriteLine();
        }
    }
}