using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO_LESSON11
{
    public struct LinearEquation
    {
        private double _k;
        private double _b;

        public LinearEquation(double k, double b)
        {
            _k = k;
            _b = b;
        }

        public double? Root()
        {
            if (_k == 0 && _b == 0)
            {
                // Бесконечно много решений
                Console.WriteLine("Бесконечно много решений.");
                return null; // null указывает на отсутствие уникального решения
            }
            else if (_k == 0)
            {
                // Нет решений
                Console.WriteLine("Нет решений.");
                return null; // null указывает на отсутствие решения
            }
            else
            {
                // Уникальное решение
                return -_b / _k;
            }
        }
    }

    class Program
    {
        static void Main()
        {
            LinearEquation equation1 = new LinearEquation(2, 4);
            Console.WriteLine($"Уравнение: 0 = {equation1.Root()} x + 4");

            var root = equation1.Root();
            if (root.HasValue)
            {
                Console.WriteLine($"Корень уравнения: x = {root.Value}");
            }

            LinearEquation equation2 = new LinearEquation(0, 4);
            Console.WriteLine($"Уравнение: 0 = {equation2.Root()} x + 4");
            equation2.Root(); // Нет решений

            LinearEquation equation3 = new LinearEquation(0, 0);
            Console.WriteLine($"Уравнение: 0 = {equation3.Root()} x + 0");
            equation3.Root(); // Бесконечно много решений
            Console.ReadKey();
        }
    }
}
