using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ITMO_LESSON13
{
    class Program
    {
        static void Main(string[] args)
        {
            MultiBuilding multi = new MultiBuilding("Петроградская набережная 39", 30.5, 100.5, 100.5, 20);
            multi.Print();
            Console.ReadKey();
        }
    }
    class Building
    {
        public string adress {  get; set; }
        public double length { get; set; }
        public double width { get; set; }
        public double height { get; set; }

        protected Building(string adress, double length, double width, double height)
        {
            this.adress = adress;
            this.length = length;
            this.width = width;
            this.height = height;
        }
        protected void Print()
        {
            Console.WriteLine($"Адрес:{this.adress}\nДлина:{this.length}\nШирина:{this.width}\nВысота:{this.height}");
        }
    }
    sealed class MultiBuilding : Building
    {
        public int floors { get; set; }
        public MultiBuilding(string adress, double length, double width, double height, int floors)
            : base(adress, length, width, height)
        {
            this.floors = floors;
        }
        public void Print()
        {
            base.Print();
            Console.WriteLine($"Этажность:{this.floors}");
        }
    }
}
