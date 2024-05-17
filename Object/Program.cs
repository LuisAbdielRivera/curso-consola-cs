using System;

namespace Object
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona();

            persona1.Name = "Luis";
            persona1.Age = 30;
            Console.WriteLine("Nombre: {0} Edad: {1}",persona1.Name, persona1.Age);

            Persona persona2 = persona1;
            persona2.Name = "Abdiel";
            persona2.Age = 25;

            Console.WriteLine("Nombre: {0} Edad: {1}", persona2.Name, persona2.Age);
            Console.WriteLine("Nombre: {0} Edad: {1}", persona1.Name, persona1.Age);
        }

        public struct Persona
        {
            public string Name;
            public int Age;
        }

        /*
        public class Persona
        {
            public string Name;
            public int Age;
        }
        */
    }
}