using System;
using System.Collections.Generic; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictonary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,Elemento> elementos = new Dictionary<string,Elemento>
            {
                {"K", new Elemento("K", "Potasio", 19)}
            };

            foreach (KeyValuePair<string, Elemento> kvp in elementos)
            {
                Elemento ElElemento = kvp.Value;

                Console.WriteLine("Clave:" + kvp.Key);
                Console.WriteLine("Valores:" + ElElemento.Simbolo + " " + ElElemento.Nombre + " " + ElElemento.NumeroAtomico);
            }
        }

        public class Elemento
        {
            public string Simbolo { get; set; }
            public string Nombre { get; set; }
            public int NumeroAtomico { get; set; }

            public Elemento(string simbolo, string nombre, int numeroatomico) 
            {
                Simbolo = simbolo;
                Nombre = nombre;
                NumeroAtomico = numeroatomico;
            }
        }
    }
}
