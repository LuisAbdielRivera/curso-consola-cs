using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Del Manejador = Ejemplo;

            Manejador("Hola Mundo");
            Ejemplo2(1, 2, Manejador);
        }

        public static void Ejemplo (string mensaje)
        {
            Console.WriteLine(mensaje);
        }
        static void Ejemplo2(int param1, int param2, Del llamada)
        {
            llamada("El número es: " + (param1 + param2).ToString());
        }

        public delegate void Del(string mensaje);
    }
}