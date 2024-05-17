using System;

namespace IterativeStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n = 0;

            /*
            do 
            { n++;
                Console.WriteLine("La sentencia es verdadera");
            } while (n > 5);
            */

            /*
            while (n < 5)
            {
                Console.WriteLine(n);
                n++;
            }
            */

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Iterando");
            }
        }
    }
}