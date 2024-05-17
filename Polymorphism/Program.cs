using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Chihuahua perro1 = new Chihuahua();

            perro1.ladrar();
            perro1.dormir();
            perro1.comer();

        }

        public abstract class Perro
        {
            public virtual void ladrar()
            {
                Console.WriteLine("Perro Ladrando");
            }
            public abstract void dormir();
            public abstract void comer();
        }

        public class Chihuahua: Perro
        {
            public override void ladrar()
            {
                Console.WriteLine("Chihuahua Ladrando");
            }
            public override void dormir()
            {
                Console.WriteLine("Chihuahua Durmiendo");
            }
            public override void comer()
            {
                Console.WriteLine("Chihuahua Comiendo");
            }
        }
    }
}
