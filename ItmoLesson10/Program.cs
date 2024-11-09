
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItmoLesson10
{
    public class Angle
    {
        private int _gradus;
        private int _min;
        private int _sec;

        public int Gradus
        {
            get { return _gradus; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(Gradus), "Грады не могут быть отрицательными");
                _gradus = value;
            }
        }

        public int Min
        {
            get { return _min; }
            set
            {
                if (value < 0 || value >= 60)
                    throw new ArgumentOutOfRangeException(nameof(Min), "Минуты должны быть в диапазоне от 0 до 59");
                _min = value;
            }
        }

        public int Sec
        {
            get { return _sec; }
            set
            {
                if (value < 0 || value >= 60)
                    throw new ArgumentOutOfRangeException(nameof(Sec), "Секунды должны быть в диапазоне от 0 до 59");
                _sec = value;
            }
        }

        public Angle(int gradus, int min, int sec)
        {
            Gradus = gradus;
            Min = min;
            Sec = sec;
        }

        public double ToRadians()
        {
            return (Gradus + Min / 60.0 + Sec / 3600.0) * (Math.PI / 180);
        }
    }

    class Program
    {
        static void Main()
        {
            try
            {
                Console.Write("Введите градусы: ");
                int g = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите угловые минуты: ");
                int m = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите угловые секунды: ");
                int s = Convert.ToInt32(Console.ReadLine());
                Angle angle = new Angle(g, m, s);
                Console.WriteLine($"Угол: {angle.Gradus}° {angle.Min}' {angle.Sec}''");
                Console.WriteLine($"Угол в радианах: {angle.ToRadians()}");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            Console.ReadKey();
        }
    }
}
