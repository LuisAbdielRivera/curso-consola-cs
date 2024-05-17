using System;

namespace ClassStatic
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado a = new Empleado("Luis", "123a");
            Empleado b = new Empleado("Abdiel", "123b");
            Empleado c = new Empleado("Rivera", "123c");

            Console.WriteLine("Numero de empleados {0}", Empleado.contadorEmpleados);
        }

        public class Empleado
        {
            public string id;
            public string nombre;
            public static int contadorEmpleados;

            public Empleado(string nombre, string id)
            {
                this.nombre = nombre;
                this.id = id;
                ++contadorEmpleados;
            }
        }
    }
}