using System;

namespace Variables
{
    class Program
    {
        static void Main(string[]args)
        {
            double area;
            int radio = 5;
            const double pi = 3.1416;
            
            area = pi * radio * radio;

            Console.WriteLine(area);
        }
    }
}
