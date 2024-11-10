using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO_LESSON14
{
    abstract class Animal
    {
        public abstract string Name { get; }

        public Animal(string name = "Unknown")
        {
            this.name = name;
        }

        protected string name;

        public abstract string Say();

        public void ShowInfo()
        {
            Console.WriteLine($"{Name}: {Say()}");
        }
    }

    class Cat : Animal
    {
        public Cat(string name = "Кошка") : base(name) { }

        public override string Name => base.name;

        public override string Say()
        {
            return "Мяу";
        }
    }

    class Dog : Animal
    {
        public Dog(string name = "Собака") : base(name) { }

        public override string Name => base.name;

        public override string Say()
        {
            return "Гав";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            Dog dog = new Dog();

            cat.ShowInfo();
            dog.ShowInfo();
            Console.ReadKey();
        }
    }

}
