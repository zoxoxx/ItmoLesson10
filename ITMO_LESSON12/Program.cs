using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO_LESSON12
{
    public static class CircleUtils
    {
        private const double Pi = 3.141592653589793238;

        public static double GetCircumference(double radius)
        {
            if (radius < 0)
            {
                throw new ArgumentException("Радиус не может быть отрицательным.");
            }
            return 2 * Pi * radius;
        }

        public static double GetArea(double radius)
        {
            if (radius < 0)
            {
                throw new ArgumentException("Радиус не может быть отрицательным.");
            }
            return Pi * radius * radius;
        }

        public static bool IsPointInsideCircle(double x, double y, double x0, double y0, double radius)
        {
            double distanceSquared = (x - x0) * (x - x0) + (y - y0) * (y - y0);
            return distanceSquared <= radius * radius;
        }
    }

    class Program
    {
        static void Main()
        {
            double radius = 5;
            double x0 = 0, y0 = 0;
            double circumference = CircleUtils.GetCircumference(radius);
            Console.WriteLine($"Длина окружности с радиусом {radius} равна {circumference}");
            double area = CircleUtils.GetArea(radius);
            Console.WriteLine($"Площадь круга с радиусом {radius} равна {area}");
            double x = 3, y = 4;
            bool isInside = CircleUtils.IsPointInsideCircle(x, y, x0, y0, radius);
            Console.WriteLine($"Точка ({x}, {y}) " + (isInside ? "принадлежит" : "не принадлежит") +
                              $" кругу с радиусом {radius} и центром в ({x0}, {y0}).");
            Console.ReadKey();
        }
    }
}
