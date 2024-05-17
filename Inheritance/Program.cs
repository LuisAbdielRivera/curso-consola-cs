using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Chihuahua perro1 = new Chihuahua();

            Console.WriteLine(perro1.PerroLadrar());
        }

        public class Perro
        {
            public string PerroLadrar() { return "Perro Ladrar"; }
        }

        public class Chihuahua: Perro
        {

        }
    }
}